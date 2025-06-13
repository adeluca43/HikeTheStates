import { useEffect, useState } from "react";
import { getAllHikes, deleteHike } from "../managers/hikeManger";
import { useNavigate } from "react-router-dom";
import { Card, CardBody, CardTitle, CardText, Badge, Button } from "reactstrap";

export default function HomePage({ loggedInUser }) {
  const [hikes, setHikes] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    getAllHikes().then(setHikes);
  }, []);

  const getTrailFeatures = (hike) => {
    const features = [];
    if (hike.isDogFriendly) features.push("Dog Friendly");
    if (hike.isKidFriendly) features.push("Kid Friendly");
    if (hike.isHandicapAccessible) features.push("Handicap Accessible");
    if (hike.hasRestrooms) features.push("Restrooms at Trailhead");
    if (hike.isPaved) features.push("Paved Trail");
    if (hike.isGravel) features.push("Gravel Path");
    return features;
  };

  const handleDelete = (id) => {
    if (window.confirm("Are you sure you want to delete this hike?")) {
      deleteHike(id).then(() => getAllHikes().then(setHikes));
    }
  };

  return (
    <div className="container mt-4">
      <h2>All Hikes</h2>
      {hikes.map((hike) => (
        <Card className="mb-3" key={hike.id}>
          <CardBody>
            <CardTitle tag="h4">{hike.title}</CardTitle>
            <CardText>
              <strong>Description:</strong> {hike.description}
            </CardText>
            <CardText>
              <strong>Location:</strong> {hike.location}
            </CardText>
            <CardText>
              <strong>Distance:</strong> {hike.distance} miles
            </CardText>
            <CardText>
              <strong>Difficulty:</strong>{" "}
              <Badge color="info">{hike.difficulty}</Badge>
            </CardText>
            <CardText>
              <strong>Trail Features:</strong>{" "}
              {getTrailFeatures(hike).length > 0
                ? getTrailFeatures(hike).join(", ")
                : "None specified"}
            </CardText>
            <CardText>
              <small className="text-muted">
                Hiked by: {hike.userFullName}
                <br />
                Created on: {new Date(hike.dateCreated).toLocaleDateString()}
              </small>
            </CardText>

            {/* ✅ Edit/Delete buttons if owned by current user */}
            {hike.userProfileId === loggedInUser.id && (
              <div className="d-flex justify-content-end gap-2">
                <Button
                  size="sm"
                  color="secondary"
                  onClick={() => navigate(`/hikes/${hike.id}/edit`)}
                >
                  ✏️
                </Button>
                <Button
                  size="sm"
                  color="danger"
                  onClick={() => handleDelete(hike.id)}
                >
                  🗑️
                </Button>
              </div>
            )}
          </CardBody>
        </Card>
      ))}
    </div>
  );
}
