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
    distance: 0,
    difficultyId: 1,
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

  const handleSubmit = (e) => {
    e.preventDefault();
    const fullAddress = `${hike.addressLine1}, ${hike.city}, ${hike.state} ${hike.zip}`;

    const hikeToSend = {
      ...hike,
      location: fullAddress,
      userProfileId: loggedInUser.id,
    };

    createHike(hikeToSend)
      .then(() => getUserProfileWithHikes(loggedInUser.id))
      .then((updatedProfile) => {
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

        navigate("/");
      });
  };

  return (
    <Container style={{ maxWidth: "700px", marginTop: "2rem" }}>
      <h2 className="mb-4 text-center">Create a New Hike</h2>
      <Form onSubmit={handleSubmit}>
        <Form.Group className="mb-3">
          <Form.Label>Title</Form.Label>
          <Form.Control
            type="text"
            name="title"
            value={hike.title}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>Description</Form.Label>
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
          <Form.Label>Address Line 1</Form.Label>
          <Form.Control
            type="text"
            name="addressLine1"
            value={hike.addressLine1}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>City</Form.Label>
          <Form.Control
            type="text"
            name="city"
            value={hike.city}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>State</Form.Label>
          <Form.Control
            type="text"
            name="state"
            value={hike.state}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>ZIP Code</Form.Label>
          <Form.Control
            type="text"
            name="zip"
            value={hike.zip}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>Distance (miles)</Form.Label>
          <Form.Control
            type="number"
            name="distance"
            value={hike.distance}
            onChange={handleChange}
            required
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>Difficulty</Form.Label>
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
          <Form.Check
            type="checkbox"
            label="Dog Friendly"
            name="isDogFriendly"
            checked={hike.isDogFriendly}
            onChange={handleChange}
          />
          <Form.Check
            type="checkbox"
            label="Kid Friendly"
            name="isKidFriendly"
            checked={hike.isKidFriendly}
            onChange={handleChange}
          />
          <Form.Check
            type="checkbox"
            label="Handicap Accessible"
            name="isHandicapAccessible"
            checked={hike.isHandicapAccessible}
            onChange={handleChange}
          />
          <Form.Check
            type="checkbox"
            label="Restrooms at Trailhead"
            name="hasRestrooms"
            checked={hike.hasRestrooms}
            onChange={handleChange}
          />
          <Form.Check
            type="checkbox"
            label="Paved Trail"
            name="isPaved"
            checked={hike.isPaved}
            onChange={handleChange}
          />
          <Form.Check
            type="checkbox"
            label="Gravel Path"
            name="isGravel"
            checked={hike.isGravel}
            onChange={handleChange}
          />
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
