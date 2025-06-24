import { useEffect, useState } from "react";
import { Routes, Route, Navigate, useLocation } from "react-router-dom";
import { Spinner } from "reactstrap";
import { tryGetLoggedInUser } from "./managers/authManager";
import NavBar from "./components/NavBar";
import Login from "./components/auth/Login";
import Register from "./components/auth/Register";
import ApplicationViews from "./components/ApplicationViews";

function App() {
  const [loggedInUser, setLoggedInUser] = useState(undefined);
  const location = useLocation();

  useEffect(() => {
    tryGetLoggedInUser().then(setLoggedInUser);
  }, []);

  // While waiting on auth check
  if (loggedInUser === undefined) {
    return (
      <div className="d-flex justify-content-center mt-5">
        <Spinner />
      </div>
    );
  }

  const isAuthPage =
    location.pathname === "/login" ||
    location.pathname === "/register" ||
    location.pathname === "/";

  return (
    <>
      {loggedInUser && !isAuthPage && (
        <NavBar loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
      )}

      <Routes>
        <Route
          path="/login"
          element={<Login setLoggedInUser={setLoggedInUser} />}
        />
        <Route
          path="/register"
          element={<Register setLoggedInUser={setLoggedInUser} />}
        />
        <Route
          path="*"
          element={
            loggedInUser ? (
              <ApplicationViews loggedInUser={loggedInUser} />
            ) : (
              <Navigate to="/login" />
            )
          }
        />
      </Routes>
    </>
  );
}

export default App;
