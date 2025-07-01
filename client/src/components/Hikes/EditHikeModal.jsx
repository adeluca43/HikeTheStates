import { useEffect, useState } from "react";
import { Modal, Form, Button } from "react-bootstrap";
import { getAllDifficulties } from "../../managers/difficultyManager";
import { getHikeById, updateHike } from "../../managers/hikeManger";

export default function EditHikeModal({ show, handleClose, hikeId, onUpdate }) {
  const [hike, setHike] = useState(null);
  const [difficulties, setDifficulties] = useState([]);

  useEffect(() => {
    if (hikeId) {
      getHikeById(hikeId).then(setHike);
      getAllDifficulties().then(setDifficulties);
    }
  }, [hikeId]);

  const handleChange = (event) => {
    const { name, value, type, checked } = event.target;
    setHike({
      ...hike,
      [name]: type === "checkbox" ? checked : value,
    });
  };

  const handleSubmit = async (event) => {
    event.preventDefault();

    const fullAddress = `${hike.addressLine1}, ${hike.city}, ${hike.state} ${hike.zip}`;

    try {
      const response = await fetch(
        `https://api.opencagedata.com/geocode/v1/json?q=${encodeURIComponent(
          fullAddress
        )}&key=d5a36cd8355347b2aaaac52711dfe410`
      );
      const data = await response.json();

      if (data.results.length > 0) {
        const { lat, lng } = data.results[0].geometry;

        const updatedHike = {
          ...hike,
          latitude: lat,
          longitude: lng,
        };

        await updateHike(hikeId, updatedHike);
        onUpdate();
        handleClose();
      } else {
        alert("Could not find location from the address.");
      }
    } catch (error) {
      console.error("Geocoding error:", error);
      alert("There was a problem geocoding the address.");
    }
  };

  if (!hike) return null;

  return (
    <Modal show={show} onHide={handleClose} size="lg">
      <Modal.Header closeButton>
        <Modal.Title>Edit Hike</Modal.Title>
      </Modal.Header>
      <Modal.Body>
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
              Save Changes
            </Button>
          </div>
        </Form>
      </Modal.Body>
    </Modal>
  );
}
