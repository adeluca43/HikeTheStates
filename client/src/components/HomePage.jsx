import { useEffect, useState } from "react";
import { getAllHikes, deleteHike } from "../managers/hikeManger";
import { useNavigate } from "react-router-dom";
import { Card, CardBody, CardTitle, CardText, Badge, Button } from "reactstrap";
import { useLocation } from "react-router-dom";
import { likeHike, getLikeCount } from "../managers/hikeManger";
import MapView from "./MapView";
import { getAllDifficulties } from "../managers/difficultyManager";

export default function HomePage({ loggedInUser }) {
  const location = useLocation();
  const [hikes, setHikes] = useState([]);
  const [difficulties, setDifficulties] = useState([]);
  const [difficultyFilter, setDifficultyFilter] = useState("All");
  const [selectedFeatures, setSelectedFeatures] = useState([]);
  const [pendingFeatures, setPendingFeatures] = useState([]);
  const [showFeatureFilter, setShowFeatureFilter] = useState(false);
  const [showMap, setShowMap] = useState(false);
  const allTrailFeatures = [
    { label: "Dog Friendly", key: "isDogFriendly" },
    { label: "Kid Friendly", key: "isKidFriendly" },
    { label: "Handicap Accessible", key: "isHandicapAccessible" },
    { label: "Restrooms at Trailhead", key: "hasRestrooms" },
    { label: "Paved Trail", key: "isPaved" },
    { label: "Gravel Path", key: "isGravel" },
  ];

  const navigate = useNavigate();

  useEffect(() => {
    getAllHikes().then(async (hikesData) => {
      const sortedHikes = hikesData.sort(
        (a, b) => new Date(b.dateCreated) - new Date(a.dateCreated)
      );

      const hikesWithLikes = await Promise.all(
        sortedHikes.map(async (hike) => {
          try {
            const likeCount = await getLikeCount(hike.id);
            return { ...hike, likeCount };
          } catch (error) {
            console.error(
              `Error getting like count for hike ${hike.id}`,
              error
            );
            return { ...hike, likeCount: 0 };
          }
        })
      );

      setHikes(hikesWithLikes);
    });
  }, [location]);

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
  const filteredHikes = hikes.filter((hike) => {
    const matchesDifficulty =
      difficultyFilter === "All" || hike.difficulty === difficultyFilter;

    const matchesFeatures = selectedFeatures.every(
      (featureKey) => hike[featureKey]
    );

    return matchesDifficulty && matchesFeatures;
  });

  useEffect(() => {
    getAllDifficulties()
      .then(setDifficulties)
      .catch((err) => console.error("Failed to load difficulties", err));
  }, []);

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

  return (
    <div className="container mt-4">
      <h2>All Hikes</h2>
      <div className="mb-3">
        <Button color="secondary" onClick={() => setShowMap(!showMap)}>
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
            color="primary"
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
        filteredHikes.map((hike) => {
          return (
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
                  <strong>Location: </strong>
                  {hike.city}, {hike.state}
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
                  {getTrailFeatures(hike).length > 0
                    ? getTrailFeatures(hike).join(", ")
                    : "None specified"}
                </CardText>
                <CardText>
                  <small className="text-muted">
                    Hiked by:{" "}
                    <span
                      style={{
                        cursor: "pointer",
                        textDecoration: "underline",
                        color: "blue",
                      }}
                      onClick={() =>
                        navigate(`/profiles/${hike.userProfileId}`)
                      }
                    >
                      {hike.userFullName}
                    </span>
                    <br />
                    Created on:{" "}
                    {new Date(hike.dateCreated).toLocaleDateString()}
                  </small>
                </CardText>

                {hike.userProfileId !== loggedInUser.id && (
                  <Button
                    size="sm"
                    color="light"
                    onClick={() => {
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
                        .catch((err) => {
                          alert(err.message);
                        });
                    }}
                  >
                    ❤️ {hike.likeCount}
                  </Button>
                )}

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
          );
        })
      )}
    </div>
  );
}
