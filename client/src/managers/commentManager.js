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

export const deleteComment = async (id) => {
  const res = await fetch(`/api/comments/${id}`, {
    method: "DELETE",
    credentials: "include" 
  });

  if (!res.ok && res.status !== 204) {
    throw new Error("Failed to delete comment");
  }
};
