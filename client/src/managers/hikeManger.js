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