import { MapContainer, TileLayer, Marker, Popup, useMap } from "react-leaflet";
import { useEffect } from "react";
import L from "leaflet";

// Import local marker icons
import markerIcon from "/leaflet/marker-icon.png";
import marker2x from "/leaflet/marker-icon-2x.png";
import markerShadow from "/leaflet/marker-shadow.png";

// Fix Leaflet's default icon URLs
delete L.Icon.Default.prototype._getIconUrl;
L.Icon.Default.mergeOptions({
  iconRetinaUrl: marker2x,
  iconUrl: markerIcon,
  shadowUrl: markerShadow,
});

// Resize fix in case map is inside a toggled component
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
  // Optionally filter out hikes with no coordinates
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
            <strong>{hike.title}</strong>
            <br />
            {hike.location}
            <br />
            Difficulty: {hike.difficulty}
          </Popup>
        </Marker>
      ))}
    </MapContainer>
  );
}
