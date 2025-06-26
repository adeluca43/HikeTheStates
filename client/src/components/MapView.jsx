import { MapContainer, TileLayer, Marker, Popup, useMap } from "react-leaflet";
import { useEffect } from "react";
import { Link } from "react-router-dom";
import L from "leaflet";
import markerIcon from "/leaflet/marker-icon.png";
import marker2x from "/leaflet/marker-icon-2x.png";
import markerShadow from "/leaflet/marker-shadow.png";

delete L.Icon.Default.prototype._getIconUrl;
L.Icon.Default.mergeOptions({
  iconRetinaUrl: marker2x,
  iconUrl: markerIcon,
  shadowUrl: markerShadow,
});

function MapResizeFixer() {
  const map = useMap();
  useEffect(() => {
    setTimeout(() => {
      map.invalidateSize();
    }, 300);
  }, [map]);
  return null;
}

export default function MapView({ hikes }) {
  const hikesWithCoords = hikes.filter((h) => h.latitude && h.longitude);

  return (
    <MapContainer
      center={[36.1627, -86.7816]} // Center on Tennessee
      zoom={8}
      className="leaflet-container"
      style={{ height: "600px", width: "100%" }}
    >
      <MapResizeFixer />
      <TileLayer url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png" />
      {hikesWithCoords.map((hike) => (
        <Marker key={hike.id} position={[hike.latitude, hike.longitude]}>
          <Popup>
            <div style={{ minWidth: "150px" }}>
              <strong>
                <Link to={`/hikes/${hike.id}`} style={{ color: "green" }}>
                  {hike.title}
                </Link>
              </strong>
              <br />
              <span>
                <strong>Distance:</strong> {hike.distance} mi
              </span>
              <br />
              <span>
                <strong>Difficulty:</strong> {hike.difficulty}
              </span>
            </div>
          </Popup>
        </Marker>
      ))}
    </MapContainer>
  );
}
