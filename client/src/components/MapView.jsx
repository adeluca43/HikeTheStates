import { MapContainer, TileLayer, Marker, Popup, useMap } from "react-leaflet";
import { useEffect } from "react";
import L from "leaflet";

// Import marker images from public/leaflet
import markerIcon from "/leaflet/marker-icon.png";
import marker2x from "/leaflet/marker-icon-2x.png";
import markerShadow from "/leaflet/marker-shadow.png";

// Fix Leaflet’s default icon paths
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
  console.log("Hikes passed to MapView:", hikes);

  // 🧪 TEMP: Hardcode coordinates for one hike if it's missing lat/lng
  const enrichedHikes = hikes.map((hike) => {
    if (hike.id === 27 && !hike.latitude && !hike.longitude) {
      return {
        ...hike,
        latitude: 36.5298,
        longitude: -87.3595, // Clarksville coords
      };
    }
    return hike;
  });

  return (
    <MapContainer
      center={[36.1627, -86.7816]} // Nashville-ish
      zoom={8}
      className="leaflet-container"
    >
      <MapResizeFixer />
      <TileLayer url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png" />

      {enrichedHikes
        .filter((hike) => hike.latitude && hike.longitude)
        .map((hike) => (
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
