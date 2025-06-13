const _apiUrl = "/api/userprofile";

export function getUserProfileWithHikes(userId) {
  return fetch(`${_apiUrl}/${userId}/hikes`).then((res) => res.json());
}

export const updateUserProfile = (id, updatedProfile) => {
  return fetch(`${_apiUrl}/${id}`, {
    method: "PUT",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(updatedProfile),
  })
};

export function getUserProfile(id) {
  return fetch(`${_apiUrl}/${id}`).then((res) => res.json());
}


