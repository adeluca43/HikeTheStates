import { useEffect, useState } from "react";
import { getUserProfileWithHikes } from "../../managers/userProfileManager";
import EditHikeModal from "../Hikes/EditHikeModal";
import { useNavigate } from "react-router-dom";

export default function MyProfile({ loggedInUser }) {
  const [profile, setProfile] = useState(null);
  const [showEditModal, setShowEditModal] = useState(false);
  const [selectedHikeId, setSelectedHikeId] = useState(null);
  const navigate = useNavigate();

  useEffect(() => {
    getUserProfileWithHikes(loggedInUser.id).then((data) => {
      setProfile(data);
    });
  }, [loggedInUser]);

  if (!profile) return <div>Loading profile...</div>;

  const stars = Math.min(10, Math.floor(profile.hikes.length / 5));

  const sortedHikes = [...profile.hikes].sort(
    (a, b) => new Date(b.dateCreated) - new Date(a.dateCreated)
  );

  const handleDelete = (hikeId) => {
    if (window.confirm("Are you sure you want to delete this hike?")) {
      fetch(`/api/hikes/${hikeId}`, { method: "DELETE" }).then(() =>
        setProfile((prev) => ({
          ...prev,
          hikes: prev.hikes.filter((h) => h.id !== hikeId),
        }))
      );
    }
  };
  const getDifficultyColor = (level) => {
    switch (level.toLowerCase()) {
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
  const openEditModal = (id) => {
    setSelectedHikeId(id);
    setShowEditModal(true);
  };

  const closeEditModal = () => {
    setSelectedHikeId(null);
    setShowEditModal(false);
  };

  const refreshProfile = () => {
    getUserProfileWithHikes(loggedInUser.id).then(setProfile);
  };
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
        <div className="d-flex justify-content-end">
          <button
            className="btn mb-3"
            style={{
              backgroundColor: "#d9cbb5",
              color: "#333",
              border: "1px solid #bfb8aa",
              fontWeight: "bold",
            }}
            onClick={() => navigate(`/edit-profile`)}
          >
            Edit Profile
          </button>
        </div>
      </div>

      <hr />

      <div className="mt-4">
        <h4>Your Hikes</h4>

        {sortedHikes.map((hike) => (
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
                <strong>Distance:</strong> {hike.distance} mi
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
                <strong>Location: </strong>
                {hike.addressLine1}, {hike.city}, {hike.state} {hike.zip}
              </p>
              <small className="text-muted">
                Date Created: {new Date(hike.dateCreated).toLocaleDateString()}
              </small>

              <div className="d-flex justify-content-end gap-2 mt-2">
                <button
                  className="btn btn-sm btn-secondary"
                  onClick={() => openEditModal(hike.id)}
                >
                  ✏️
                </button>

                <button
                  className="btn btn-sm btn-danger"
                  onClick={() => handleDelete(hike.id)}
                >
                  🗑️
                </button>
              </div>
            </div>
          </div>
        ))}
        <EditHikeModal
          show={showEditModal}
          handleClose={closeEditModal}
          hikeId={selectedHikeId}
          onUpdate={refreshProfile}
        />
      </div>
    </div>
  );
}
