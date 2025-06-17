import { useEffect, useState } from "react";
import { getUserProfileWithHikes } from "../../managers/userProfileManager";
import { useParams } from "react-router-dom";

export default function OtherProfileDetail() {
  const { id } = useParams();
  const [profile, setProfile] = useState(null);

  useEffect(() => {
    getUserProfileWithHikes(id).then(setProfile);
  }, [id]);

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
          title="Earn 1 star for every 5 hikes completed (up to 10 stars)"
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
        {profile.hikes.map((hike) => (
          <div key={hike.id} className="card my-3">
            <div className="card-body">
              <h5>{hike.title}</h5>
              <p>
                <strong>Difficulty:</strong> {hike.difficulty}
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
                <strong>Location:</strong> {hike.location}
              </p>
              <small className="text-muted">
                Date Created: {new Date(hike.dateCreated).toLocaleDateString()}
              </small>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}
