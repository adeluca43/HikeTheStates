const _apiUrl = "/api/hikes";

export const getAllHikes = () => {
  return fetch(_apiUrl).then((res) => {
    if (!res.ok) throw new Error("Failed to fetch hikes");
    return res.json();
  });
};

export const createHike = (hike) => {
  return fetch(_apiUrl, {
    method: "POST",
    headers: {
      "Content-Type": "application/json"
    },
    body: JSON.stringify(hike)
  }).then((res) => res.json());
};

export const deleteHike = (id) => {
  return fetch(`${_apiUrl}/${id}`, {
    method: "DELETE"
  });
};

export function getHikeById(id) {
  return fetch(`${_apiUrl}/${id}`).then((res) => res.json());
}

export function updateHike(id, hike) {
  return fetch(`${_apiUrl}/${id}`, {
    method: "PUT",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(hike),
  });
}
