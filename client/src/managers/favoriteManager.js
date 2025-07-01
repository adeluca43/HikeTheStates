const baseUrl = "/api/favorites";

export const getUserFavorites = (userId) => {
  return fetch(`${baseUrl}/user/${userId}`).then((res) => res.json());
};

export const addFavorite = (favorite) => {
  return fetch(baseUrl, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(favorite),
  }).then((res) => {
    if (!res.ok) {
      return res.text().then((text) => {
        throw new Error(text);
      });
    }
    return res.json();
  });
};

export const removeFavorite = (userId, hikeId) => {
  return fetch(`${baseUrl}?userId=${userId}&hikeId=${hikeId}`, {
    method: "DELETE",
  });
};
