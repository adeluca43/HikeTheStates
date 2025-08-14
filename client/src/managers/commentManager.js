const _apiUrl = "/api/comments"; 

export const getCommentsByHikeId = (hikeId) => {
  return fetch(`${_apiUrl}/hike/${hikeId}`, {
    credentials: "include", 
  }).then((res) => {
    if (!res.ok) throw new Error("Failed to fetch comments");
    return res.json();
  });
};

export const addComment = (comment) => {
  return fetch(_apiUrl, {
    method: "POST",
    credentials: "include",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(comment),
  });
};

export const deleteComment = async (id) => {
  const res = await fetch(`${_apiUrl}/${id}`, {
    method: "DELETE",
    credentials: "include",
  });
  if (res.status === 204) return;
  if (!res.ok) {
    const text = await res.text();
    throw new Error(text || "Failed to delete comment");
  }
};
