import { Routes, Route } from "react-router-dom";
import HomePage from "./HomePage";
import CreateHike from "./Hikes/CreateHike";
import MyProfile from "./Profile/MyProfile";
import EditProfile from "./Profile/EditProfile";
import { AuthorizedRoute } from "./auth/AuthorizeRoute";

export default function ApplicationViews({ loggedInUser }) {
  return (
    <Routes>
      <Route
        path="/"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <HomePage loggedInUser={loggedInUser} />
          </AuthorizedRoute>
        }
      />
      <Route
        path="/hikes/new"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <CreateHike loggedInUser={loggedInUser} />
          </AuthorizedRoute>
        }
      />
      <Route
        path="/profile"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <MyProfile loggedInUser={loggedInUser} />
          </AuthorizedRoute>
        }
      />
      <Route
        path="/edit-profile"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <EditProfile loggedInUser={loggedInUser} />
          </AuthorizedRoute>
        }
      />
    </Routes>
  );
}
