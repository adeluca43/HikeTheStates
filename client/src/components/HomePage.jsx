import { useEffect, useState } from "react";
import { getAllHikes } from "../managers/hikeManger";
import { Card, CardBody, CardTitle, CardText, Badge } from "reactstrap";

export default function HomePage() {
  const [hikes, setHikes] = useState([]);

  useEffect(() => {
    getAllHikes().then(setHikes);
  }, []);

  return (
    <div className="container mt-4">
      <h2>All Hikes</h2>
      {hikes.map(hike => (
        <Card className="mb-3" key={hike.id}>
          <CardBody>
            <CardTitle tag="h4">{hike.title}</CardTitle>
            <CardText><strong>Description:</strong> {hike.description}</CardText>
            <CardText><strong>Location:</strong> {hike.location}</CardText>
            <CardText><strong>Distance:</strong> {hike.distance} miles</CardText>
            <CardText>
              <strong>Difficulty:</strong>{" "}
              <Badge color="info">{hike.difficulty}</Badge>
            </CardText>
            <CardText>
              <strong>Dog Friendly:</strong>{" "}
              {hike.isDogFriendly ? "Yes" : "No"}
            </CardText>
            <CardText>
              <small className="text-muted">Added by: {hike.userFullName}</small>
            </CardText>
          </CardBody>
        </Card>
      ))}
    </div>
  );
}
