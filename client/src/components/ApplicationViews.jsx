import { Routes, Route } from "react-router-dom";
import HomePage from "./HomePage";
import CreateHike from "./Hikes/CreateHike";
import MyProfile from "./Profile/MyProfile";
import EditProfile from "./Profile/EditProfile";
import { AuthorizedRoute } from "./auth/AuthorizeRoute";
import OtherProfileDetail from "./Profile/OtherProfileDetails";
import HikeDetails from "./Hikes/HikeDetails";
import WelcomePage from "./WelcomePage";

export default function ApplicationViews({ loggedInUser }) {
  return (
    <Routes>
      <Route
        path="/home"
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
      <Route
        path="/profiles/:id"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <OtherProfileDetail loggedInUser={loggedInUser} />
          </AuthorizedRoute>
        }
      />
      <Route
        path="/hikes/:hikeId"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <HikeDetails />
          </AuthorizedRoute>
        }
      />
      <Route
        path="/favorites"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <FavoritesPage />
          </AuthorizedRoute>
        }
      />
      <Route
        path="/"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <WelcomePage />
          </AuthorizedRoute>
        }
      />
    </Routes>
  );
}
