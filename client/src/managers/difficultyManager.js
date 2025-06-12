const _apiUrl = "/api/difficulty";

export const getAllDifficulties = () => {
  return fetch(_apiUrl).then((res) => res.json());
};
