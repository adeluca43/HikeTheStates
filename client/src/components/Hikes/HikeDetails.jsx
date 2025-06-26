import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { getHikeById } from "../../managers/hikeManger";
import { Container, Card, Badge } from "react-bootstrap";

const getDifficultyColor = (level) => {
  switch (level?.toLowerCase()) {
    case "easy":
      return "#28a745";
    case "moderate":
      return "#ffc107";
    case "challenging":
      return "#fd7e14";
    case "hard":
      return "#dc3545";
    default:
      return "#6c757d";
  }
};

export default function HikeDetails() {
  const { hikeId } = useParams();
  const [hike, setHike] = useState(null);

  useEffect(() => {
    getHikeById(hikeId).then((data) => {
      setHike(data);
    });
  }, [hikeId]);
  const navigate = useNavigate();
  if (!hike) return <p>Loading...</p>;

  const trailFeatures = [
    hike.isDogFriendly && "Dog Friendly",
    hike.isKidFriendly && "Kid Friendly",
    hike.isHandicapAccessible && "Handicap Accessible",
    hike.hasRestrooms && "Restrooms at Trailhead",
    hike.isPaved && "Paved Trail",
    hike.isGravel && "Gravel Path",
  ].filter(Boolean);

  return (
    <Container style={{ maxWidth: "800px", marginTop: "2rem" }}>
      <button
        className="btn btn-secondary mb-3"
        onClick={() => navigate("/home", { state: { showMap: true } })}
      >
        ← Back to Map
      </button>

      <Card className="p-4" style={{ backgroundColor: "#f5f0e6" }}>
        <h2 className="mb-3">{hike.title}</h2>

        <p>
          <strong>Description:</strong> {hike.description}
        </p>
        <p>
          <strong>Distance:</strong> {hike.distance} miles
        </p>
        <p>
          <strong>Location: </strong>
          {hike.addressLine1}, {hike.city}, {hike.state} {hike.zip}
        </p>
        <p>
          <strong>Difficulty:</strong>{" "}
          <Badge
            style={{
              backgroundColor: getDifficultyColor(hike.difficultyLevel),
              color: "white",
            }}
          >
            {hike.difficultyLevel}
          </Badge>
        </p>
        <p>
          <strong>Trail Features:</strong>{" "}
          {trailFeatures.length > 0 ? trailFeatures.join(", ") : "None"}
        </p>
        <p>
          <strong>Hiked By:</strong> {hike.userFullName || "Unknown"}
        </p>
        <p className="text-muted mt-3">
          Hike created on {new Date(hike.dateCreated).toLocaleDateString()}
        </p>
      </Card>
    </Container>
  );
}
