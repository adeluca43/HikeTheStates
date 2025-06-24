import { useEffect, useState } from "react";
import { createHike } from "../../managers/hikeManger";
import { getAllDifficulties } from "../../managers/difficultyManager";
import { useNavigate } from "react-router-dom";
import { Container, Form, Button } from "react-bootstrap";
import { getUserProfileWithHikes } from "../../managers/userProfileManager";

export default function CreateHike({ loggedInUser }) {
  const [difficulties, setDifficulties] = useState([]);
  const [hike, setHike] = useState({
    title: "",
    description: "",
    location: "",
    addressLine1: "",
    city: "",
    state: "",
    zip: "",
    distance: "",
    difficultyId: "",
    isDogFriendly: false,
    isKidFriendly: false,
    isHandicapAccessible: false,
    hasRestrooms: false,
    isPaved: false,
    isGravel: false,
    userProfileId: 0,
  });
  const navigate = useNavigate();

  useEffect(() => {
    getAllDifficulties().then(setDifficulties);
  }, []);

  const handleChange = (e) => {
    const field = e.target.name;
    const value =
      e.target.type === "checkbox" ? e.target.checked : e.target.value;

    setHike((prevState) => {
      return {
        ...prevState,
        [field]: value,
      };
    });
  };
  const geocodeAddress = async (address) => {
    const apiKey = "d5a36cd8355347b2aaaac52711dfe410"; // for dev use only
    const url = `https://api.opencagedata.com/geocode/v1/json?q=${encodeURIComponent(
      address
    )}&key=${apiKey}`;

    const response = await fetch(url);
    const data = await response.json();

    if (data.results.length > 0) {
      return data.results[0].geometry; // { lat, lng }
    } else {
      throw new Error("Could not geocode the address");
    }
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    const fullAddress = `${hike.addressLine1}, ${hike.city}, ${hike.state} ${hike.zip}`;

    try {
      const { lat, lng } = await geocodeAddress(fullAddress);
      console.log("Geocoded coords:", lat, lng);
      const hikeToSend = {
        ...hike,
        location: fullAddress,
        latitude: lat,
        longitude: lng,
        userProfileId: loggedInUser.id,
      };
      console.log("Submitting hike:", hikeToSend);
      await createHike(hikeToSend);
      const updatedProfile = await getUserProfileWithHikes(loggedInUser.id);
      const totalHikes = updatedProfile.hikes.length;
      const starsNow = Math.floor(totalHikes / 5);
      const hikesToNextStar = 5 - (totalHikes % 5);

      if (totalHikes % 5 === 0) {
        alert(
          `🎉 Congrats! You've earned a new star! You now have ${starsNow} stars.`
        );
      } else {
        alert(
          `🌟 You're only ${hikesToNextStar} hike(s) away from your next star!`
        );
      }

      navigate("/home");
    } catch (error) {
      console.error("Geocoding error:", error);
      alert("There was an issue geocoding the address. Please try again.");
    }
  };

  return (
    <Container style={{ maxWidth: "700px", marginTop: "2rem" }}>
      <h2 className="mb-4 text-center fw-bold">Create a New Hike</h2>
      <Form onSubmit={handleSubmit}>
        <Form.Group className="mb-3">
          <Form.Label className="fw-bold">Title</Form.Label>
          <Form.Control
            type="text"
            name="title"
            value={hike.title}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label className="fw-bold">Description</Form.Label>
          <Form.Control
            as="textarea"
            rows={3}
            name="description"
            value={hike.description}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label className="fw-bold">Address Line 1</Form.Label>
          <Form.Control
            type="text"
            name="addressLine1"
            value={hike.addressLine1}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label className="fw-bold">City</Form.Label>
          <Form.Control
            type="text"
            name="city"
            value={hike.city}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label className="fw-bold">State</Form.Label>
          <Form.Control
            type="text"
            name="state"
            value={hike.state}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label className="fw-bold">ZIP Code</Form.Label>
          <Form.Control
            type="text"
            name="zip"
            value={hike.zip}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label className="fw-bold">Distance (miles)</Form.Label>
          <Form.Control
            type="number"
            name="distance"
            value={hike.distance}
            onChange={handleChange}
            min="0.1"
            step="0.1"
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label className="fw-bold">Difficulty</Form.Label>
          <Form.Select
            name="difficultyId"
            value={hike.difficultyId}
            onChange={handleChange}
            required
          >
            <option value="">-- Select Difficulty --</option>
            {difficulties.map((d) => (
              <option key={d.id} value={d.id}>
                {d.level}
              </option>
            ))}
          </Form.Select>
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label className="fw-bold">Trail Features</Form.Label>
          <div className="d-flex flex-column gap-2">
            {[
              { label: "Dog Friendly", key: "isDogFriendly" },
              { label: "Kid Friendly", key: "isKidFriendly" },
              { label: "Handicap Accessible", key: "isHandicapAccessible" },
              { label: "Restrooms at Trailhead", key: "hasRestrooms" },
              { label: "Paved Trail", key: "isPaved" },
              { label: "Gravel Path", key: "isGravel" },
            ].map((feature) => (
              <div
                key={feature.key}
                className="form-check d-flex align-items-center gap-2"
              >
                <input
                  type="checkbox"
                  className="form-check-input"
                  name={feature.key}
                  id={feature.key}
                  checked={hike[feature.key]}
                  onChange={handleChange}
                />
                <label className="form-check-label" htmlFor={feature.key}>
                  {feature.label}
                </label>
              </div>
            ))}
          </div>
        </Form.Group>

        <div className="text-end">
          <Button type="submit" variant="dark">
            Save Hike
          </Button>
        </div>
      </Form>
    </Container>
  );
}
