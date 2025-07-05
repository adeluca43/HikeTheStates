import { useEffect, useState } from "react";
import { getUserFavorites } from "../../managers/favoriteManager";
import { Card, CardBody, CardTitle, CardText, Badge } from "reactstrap";

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

export default function FavoritesPage({ loggedInUser }) {
  const [favorites, setFavorites] = useState([]);

  useEffect(() => {
    getUserFavorites(loggedInUser.id).then(setFavorites);
  }, [loggedInUser]);

  return (
    <div className="container mt-4">
      <h2>Your Favorite Hikes</h2>
      {favorites.length === 0 ? (
        <p>You haven’t favorited any hikes yet.</p>
      ) : (
        favorites.map((hike) => {
          const trailFeatures = getTrailFeatures(hike);
          return (
            <Card
              key={hike.id}
              className="mb-3 p-3"
              style={{ backgroundColor: "#f5f0e6" }}
            >
              <CardBody>
                <CardTitle tag="h4">{hike.title}</CardTitle>

                <CardText>
                  <strong>Description:</strong> {hike.description}
                </CardText>

                <CardText>
                  <strong>Distance:</strong> {hike.distance} miles
                </CardText>

                <CardText>
                  <strong>Location:</strong> {hike.addressLine1}, {hike.city},{" "}
                  {hike.state} {hike.zip}
                </CardText>

                <CardText>
                  <strong>Difficulty:</strong>{" "}
                  <Badge
                    style={{
                      backgroundColor: getDifficultyColor(hike.difficultyLevel),
                      color: "white",
                    }}
                  >
                    {hike.difficultyLevel}
                  </Badge>
                </CardText>

                <CardText>
                  <strong>Trail Features:</strong>{" "}
                  {trailFeatures.length > 0 ? trailFeatures.join(", ") : "None"}
                </CardText>

                <CardText>
                  <strong>Hiked By:</strong> {hike.userFullName}
                </CardText>

                <CardText className="text-muted">
                  Hike created on{" "}
                  {new Date(hike.dateCreated).toLocaleDateString()}
                </CardText>
              </CardBody>
            </Card>
          );
        })
      )}
    </div>
  );
}
