import { useEffect, useState } from "react";
import { getUserFavorites } from "../../managers/favoriteManager";
import { Card, CardBody, CardTitle, CardText } from "reactstrap";

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
        favorites.map((hike) => (
          <Card
            key={hike.id}
            className="mb-3"
            style={{ backgroundColor: "#f5f0e6" }}
          >
            <CardBody>
              <CardTitle tag="h4">{hike.title}</CardTitle>
              <CardText>{hike.description}</CardText>
              <CardText>
                <strong>Location:</strong> {hike.city}, {hike.state}
              </CardText>
              <CardText>
                <strong>Distance:</strong> {hike.distance} miles
              </CardText>
            </CardBody>
          </Card>
        ))
      )}
    </div>
  );
}
