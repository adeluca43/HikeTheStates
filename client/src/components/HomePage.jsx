import { useEffect, useState } from "react";
import { useLocation, useNavigate } from "react-router-dom";
import { Card, CardBody, CardTitle, CardText, Badge, Button } from "reactstrap";
import {
  getAllHikes,
  deleteHike,
  likeHike,
  getLikeCount,
} from "../managers/hikeManger";
import { getAllDifficulties } from "../managers/difficultyManager";
import { toggleFavoriteForUser } from "../managers/favoriteManager";
import MapView from "./MapView";
import EditHikeModal from "./Hikes/EditHikeModal";

export default function HomePage({ loggedInUser }) {
  const navigate = useNavigate();
  const location = useLocation();

  const [hikes, setHikes] = useState([]);
  const [difficulties, setDifficulties] = useState([]);
  const [difficultyFilter, setDifficultyFilter] = useState("All");
  const [selectedFeatures, setSelectedFeatures] = useState([]);
  const [pendingFeatures, setPendingFeatures] = useState([]);
  const [showFeatureFilter, setShowFeatureFilter] = useState(false);
  const [showMap, setShowMap] = useState(location.state?.showMap || false);

  const [showEditModal, setShowEditModal] = useState(false);
  const [selectedHikeId, setSelectedHikeId] = useState(null);

  const allTrailFeatures = [
    { label: "Dog Friendly", key: "isDogFriendly" },
    { label: "Kid Friendly", key: "isKidFriendly" },
    { label: "Handicap Accessible", key: "isHandicapAccessible" },
    { label: "Restrooms at Trailhead", key: "hasRestrooms" },
    { label: "Paved Trail", key: "isPaved" },
    { label: "Gravel Path", key: "isGravel" },
  ];

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

  const fetchHikes = () => {
    getAllHikes().then(async (data) => {
      const sorted = data.sort(
        (a, b) => new Date(b.dateCreated) - new Date(a.dateCreated)
      );

      const withLikes = await Promise.all(
        sorted.map(async (hike) => {
          const likeCount = await getLikeCount(hike.id).catch(() => 0);
          return { ...hike, likeCount };
        })
      );

      setHikes(withLikes);
    });
  };

  useEffect(() => {
    fetchHikes();
  }, [location]);

  useEffect(() => {
    getAllDifficulties().then(setDifficulties);
  }, []);

  const openEditModal = (id) => {
    setSelectedHikeId(id);
    setShowEditModal(true);
  };

  const closeEditModal = () => {
    setSelectedHikeId(null);
    setShowEditModal(false);
  };

  const handleDelete = (id) => {
    if (window.confirm("Are you sure you want to delete this hike?")) {
      deleteHike(id).then(fetchHikes);
    }
  };

  const toggleFavorite = async (hikeId) => {
    try {
      await toggleFavoriteForUser(loggedInUser.id, hikeId);
      setHikes((prev) =>
        prev.map((h) =>
          h.id === hikeId ? { ...h, isFavorited: !h.isFavorited } : h
        )
      );
    } catch (err) {
      alert("Failed to update favorite.");
      console.error(err);
    }
  };

  const filteredHikes = hikes.filter((hike) => {
    const matchesDifficulty =
      difficultyFilter === "All" || hike.difficulty === difficultyFilter;

    const matchesFeatures = selectedFeatures.every(
      (featureKey) => hike[featureKey]
    );

    return matchesDifficulty && matchesFeatures;
  });

  return (
    <div className="container mt-4">
      <h2>All Hikes</h2>

      <div className="mb-3">
        <Button color="success" onClick={() => setShowMap(!showMap)}>
          {showMap ? "Show List View" : "Show Map View"}
        </Button>
      </div>

      <div className="row mb-3">
        <div className="col-md-6 mb-3">
          <label htmlFor="difficulty-filter" className="form-label">
            Filter by Difficulty:
          </label>
          <select
            id="difficulty-filter"
            className="form-select"
            value={difficultyFilter}
            onChange={(e) => setDifficultyFilter(e.target.value)}
          >
            <option value="All">All</option>
            {difficulties.map((d) => (
              <option key={d.id} value={d.level}>
                {d.level}
              </option>
            ))}
          </select>
        </div>

        <div className="col-md-6 mb-3">
          <Button
            color="success"
            onClick={() => {
              setPendingFeatures(selectedFeatures);
              setShowFeatureFilter(!showFeatureFilter);
            }}
          >
            {showFeatureFilter ? "Hide Feature Filters" : "Filter by Features"}
          </Button>

          {showFeatureFilter && (
            <div className="border p-3 mt-2 rounded bg-light">
              <strong>Select one or more features:</strong>
              <div className="d-flex flex-column mt-2">
                {allTrailFeatures.map((feature) => (
                  <div
                    key={feature.key}
                    className="form-check mb-1 d-flex align-items-center"
                  >
                    <input
                      className="form-check-input me-2"
                      type="checkbox"
                      id={feature.key}
                      checked={pendingFeatures.includes(feature.key)}
                      onChange={() =>
                        setPendingFeatures((prev) =>
                          prev.includes(feature.key)
                            ? prev.filter((f) => f !== feature.key)
                            : [...prev, feature.key]
                        )
                      }
                    />
                    <label className="form-check-label" htmlFor={feature.key}>
                      {feature.label}
                    </label>
                  </div>
                ))}
              </div>
              <Button
                className="mt-3"
                color="success"
                onClick={() => {
                  setSelectedFeatures(pendingFeatures);
                  setShowFeatureFilter(false);
                }}
              >
                Show Trails
              </Button>
            </div>
          )}
        </div>
      </div>

      {showMap ? (
        <MapView hikes={filteredHikes} />
      ) : (
        filteredHikes.map((hike) => (
          <Card
            className="mb-3"
            key={hike.id}
            style={{ backgroundColor: "#f5f0e6" }}
          >
            <CardBody>
              <CardTitle tag="h4">{hike.title}</CardTitle>
              <CardText>
                <strong>Description:</strong> {hike.description}
              </CardText>
              <CardText>
                <strong>Location:</strong> {hike.city}, {hike.state}
              </CardText>
              <CardText>
                <strong>Distance:</strong> {hike.distance} miles
              </CardText>
              <CardText>
                <strong>Difficulty:</strong>{" "}
                <Badge
                  color="none"
                  style={{
                    backgroundColor: getDifficultyColor(hike.difficulty),
                    color: "white",
                  }}
                >
                  {hike.difficulty}
                </Badge>
              </CardText>
              <CardText>
                <strong>Trail Features:</strong>{" "}
                {getTrailFeatures(hike).join(", ") || "None specified"}
              </CardText>
              <CardText>
                <small className="text-muted">
                  <strong>Hiked by:</strong>{" "}
                  <span
                    style={{
                      cursor: "pointer",
                      color: "green",
                      textDecoration: "underline",
                    }}
                    onClick={() => navigate(`/profiles/${hike.userProfileId}`)}
                  >
                    {hike.userFullName}
                  </span>
                  <br />
                  <strong>Created on:</strong>{" "}
                  {new Date(hike.dateCreated).toLocaleDateString()}
                </small>
              </CardText>

              {/* Buttons */}
              <div className="d-flex gap-2">
                {hike.userProfileId !== loggedInUser.id && (
                  <Button
                    size="sm"
                    color="light"
                    onClick={() =>
                      likeHike(hike.id)
                        .then((result) => {
                          setHikes((prev) =>
                            prev.map((h) =>
                              h.id === hike.id
                                ? {
                                    ...h,
                                    likeCount:
                                      result.status === "liked"
                                        ? h.likeCount + 1
                                        : h.likeCount - 1,
                                  }
                                : h
                            )
                          );
                        })
                        .catch((err) => alert(err.message))
                    }
                  >
                    ❤️ {hike.likeCount}
                  </Button>
                )}

                <Button
                  size="sm"
                  color="link"
                  onClick={() => toggleFavorite(hike.id)}
                  title="Favorite this hike"
                  style={{
                    color: hike.isFavorited ? "green" : "white",
                    fontSize: "1.25rem",
                    textDecoration: "none",
                    padding: 0,
                    border: "none",
                    background: "none",
                  }}
                >
                  🌟
                </Button>

                {hike.userProfileId === loggedInUser.id && (
                  <div className="d-flex gap-2 ms-auto">
                    <Button
                      size="sm"
                      color="secondary"
                      onClick={() => openEditModal(hike.id)}
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
              </div>
            </CardBody>
          </Card>
        ))
      )}

      <EditHikeModal
        show={showEditModal}
        handleClose={closeEditModal}
        hikeId={selectedHikeId}
        onUpdate={fetchHikes}
      />
    </div>
  );
}
