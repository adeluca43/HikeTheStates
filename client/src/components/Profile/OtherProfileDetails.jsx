import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Button } from "reactstrap";
import { getUserProfileWithHikes } from "../../managers/userProfileManager";
import { likeHike, getLikeCount } from "../../managers/hikeManger"; // note: same typo as HomePage
import {
  addFavorite,
  removeFavorite,
  getUserFavorites,
} from "../../managers/favoriteManager";

export default function OtherProfileDetail({ loggedInUser }) {
  const { id } = useParams();
  const [profile, setProfile] = useState(null);

  // map of { [hikeId]: likeCount }
  const [likeCounts, setLikeCounts] = useState({});
  // array of { id: hikeId } just like HomePage expects
  const [userFavorites, setUserFavorites] = useState([]);

  useEffect(() => {
    getUserProfileWithHikes(id).then(setProfile);
  }, [id]);

  // load like counts once hikes are available
  useEffect(() => {
    if (!profile?.hikes?.length) return;
    (async () => {
      const counts = await Promise.all(
        profile.hikes.map((h) => getLikeCount(h.id).catch(() => 0))
      );
      const map = Object.fromEntries(
        profile.hikes.map((h, i) => [h.id, counts[i]])
      );
      setLikeCounts(map);
    })();
  }, [profile]);

  // load viewer's favorites
  useEffect(() => {
    if (loggedInUser) {
      getUserFavorites(loggedInUser.id).then(setUserFavorites);
    }
  }, [loggedInUser]);

  const getDifficultyColor = (level) => {
    switch ((level || "").toLowerCase()) {
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

  const handleToggleFavorite = async (hikeId) => {
    if (!loggedInUser) {
      alert("Please log in to favorite hikes.");
      return;
    }
    const isFavorited = userFavorites.some((f) => f.id === hikeId);
    try {
      if (isFavorited) {
        await removeFavorite(loggedInUser.id, hikeId);
        setUserFavorites((prev) => prev.filter((f) => f.id !== hikeId));
        alert("Hike removed from favorites.");
      } else {
        await addFavorite({ userProfileId: loggedInUser.id, hikeId });
        setUserFavorites((prev) => [...prev, { id: hikeId }]);
        alert("Hike added to favorites!");
      }
    } catch (err) {
      console.error(err);
      alert("There was an error updating your favorites.");
    }
  };

  const handleLike = async (hike) => {
    if (!loggedInUser) {
      alert("Please log in to like hikes.");
      return;
    }
    try {
      const result = await likeHike(hike.id);
      setLikeCounts((prev) => ({
        ...prev,
        [hike.id]: (prev[hike.id] ?? 0) + (result.status === "liked" ? 1 : -1),
      }));
    } catch (err) {
      alert(err.message || "Error toggling like.");
      console.error(err);
    }
  };

  if (!profile) return <div>Loading profile...</div>;

  const stars = Math.min(10, Math.floor(profile.hikes.length / 5));

  return (
    <div className="container mt-4">
      <div className="text-center">
        <img
          src={profile.imageLocation}
          alt="Profile"
          className="rounded-circle mb-3"
          style={{ width: "150px", height: "150px" }}
        />
        <h2>{profile.fullName}</h2>

        <div
          className="mb-2 d-flex justify-content-center"
          title="Earn 1 star for every 5 hikes completed"
        >
          {Array.from({ length: 10 }).map((_, i) => (
            <svg
              key={i}
              xmlns="http://www.w3.org/2000/svg"
              width="24"
              height="24"
              viewBox="0 0 24 24"
              fill={i < stars ? "#f5c518" : "white"}
              stroke={i < stars ? "#f5c518" : "#e0e0e0"}
              strokeWidth="2"
              style={{ marginRight: "4px" }}
            >
              <polygon points="12,2 15,8.5 22,9.3 17,14.2 18.3,21 12,17.8 5.7,21 7,14.2 2,9.3 9,8.5" />
            </svg>
          ))}
        </div>
      </div>

      <hr />

      <div className="mt-4">
        <h4>{profile.fullName.split(" ")[0]}'s Hikes</h4>

        {profile.hikes.map((hike) => {
          const isFavorited = userFavorites.some((f) => f.id === hike.id);
          const likeCount = likeCounts[hike.id] ?? 0;
          const isMyHike =
            !!loggedInUser && hike.userProfileId === loggedInUser.id;

          return (
            <div
              key={hike.id}
              className="card my-3"
              style={{ backgroundColor: "#f5f0e6" }}
            >
              <div className="card-body">
                <h5>{hike.title}</h5>

                <p>
                  <strong>Difficulty:</strong>{" "}
                  <span
                    className="badge"
                    style={{
                      backgroundColor: getDifficultyColor(hike.difficulty),
                      color: "white",
                    }}
                  >
                    {hike.difficulty}
                  </span>
                </p>

                <p>
                  <strong>Trail Features:</strong>{" "}
                  {[
                    hike.isDogFriendly && "Dog Friendly",
                    hike.isKidFriendly && "Kid Friendly",
                    hike.isHandicapAccessible && "Handicap Accessible",
                    hike.hasRestrooms && "Restrooms at Trailhead",
                    hike.isPaved && "Paved Path",
                    hike.isGravel && "Gravel Path",
                  ]
                    .filter(Boolean)
                    .join(", ")}
                </p>

                <p>
                  <strong>Description:</strong> {hike.description}
                </p>

                <p>
                  <strong>Location:</strong> {hike.addressLine1}, {hike.city},{" "}
                  {hike.state}
                </p>

                <small className="text-muted d-block mb-2">
                  Date Created:{" "}
                  {new Date(hike.dateCreated).toLocaleDateString()}
                </small>

                {/* Buttons: ❤️ like (hide on your own hike) + ★ favorite */}
                <div className="d-flex gap-2">
                  {!isMyHike && (
                    <Button
                      size="sm"
                      color="light"
                      onClick={() => handleLike(hike)}
                      title="Like / Unlike"
                    >
                      ❤️ {likeCount}
                    </Button>
                  )}

                  <Button
                    size="sm"
                    style={{
                      backgroundColor: "transparent",
                      border: "none",
                      fontSize: "1.5rem",
                      padding: 0,
                    }}
                    onClick={() => handleToggleFavorite(hike.id)}
                    title={
                      isFavorited
                        ? "Unfavorite this hike"
                        : "Favorite this hike"
                    }
                  >
                    <span style={{ color: isFavorited ? "green" : "gray" }}>
                      {isFavorited ? "★" : "☆"}
                    </span>
                  </Button>
                </div>
              </div>
            </div>
          );
        })}
      </div>
    </div>
  );
}
