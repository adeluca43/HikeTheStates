import { useEffect, useState } from "react";
import { createHike } from "../../managers/hikeManger";
import { getAllDifficulties } from "../../managers/difficultyManager";
import { useNavigate } from "react-router-dom";
import { Container, Form, Button } from "react-bootstrap";

export default function CreateHike({ loggedInUser }) {
  const [difficulties, setDifficulties] = useState([]);
  const [hike, setHike] = useState({
    title: "",
    description: "",
    location: "", 
    distance: "",
    difficultyId: "", 
    isDogFriendly: false
  });

  const navigate = useNavigate();

  useEffect(() => {
    getAllDifficulties().then(setDifficulties);
  }, []);

  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    const newValue = type === "checkbox" ? checked : value;
    setHike((prev) => ({ ...prev, [name]: newValue }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const hikeToSend = { ...hike, userProfileId: loggedInUser.id };
    createHike(hikeToSend).then(() => navigate("/"));
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
          <Form.Label>Full Address</Form.Label>
          <Form.Control
            type="text"
            name="location"
            value={hike.location}
            onChange={handleChange}
            placeholder="123 Main St, City, State ZIP"
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
            {difficulties.map(d => (
              <option key={d.id} value={d.id}>
                {d.level}
              </option>
            ))}
          </Form.Select>
        </Form.Group>

        <Form.Group className="form-check mb-3">
          <Form.Check
            type="checkbox"
            label="Dog Friendly"
            name="isDogFriendly"
            checked={hike.isDogFriendly}
            onChange={handleChange}
          />
        </Form.Group>

        <div className="text-end">
          <Button type="submit" color="dark">
            Save Hike
          </Button>
        </div>
      </Form>
    </Container>
  );
}
