const _apiUrl = "/api/comments";

export const getCommentsByHikeId = (hikeId) => {
  return fetch(`${_apiUrl}/hike/${hikeId}`).then((res) => res.json());
};

export const addComment = (comment) => {
  return fetch(_apiUrl, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(comment),
  });
};

