import { NavLink, useNavigate } from "react-router-dom";
import { logout } from "../managers/authManager";

export default function NavBar({ loggedInUser, setLoggedInUser }) {
  const navigate = useNavigate();

  const handleLogout = () => {
    logout().then(() => {
      setLoggedInUser(null);
      navigate("/login");
    });
  };

  return (
    <nav className="navbar navbar-expand bg-success px-4">
      <div className="container-fluid d-flex justify-content-between align-items-center">
        <div className="text-white fw-bold">
          {loggedInUser && <>Welcome, {loggedInUser.firstName}</>}
        </div>

        <div className="d-flex align-items-center gap-4">
          {loggedInUser ? (
            <>
              <NavLink className="nav-link text-white" to="/">
                Home
              </NavLink>
              <NavLink className="nav-link text-white" to="/hikes/new">
                Add Hike
              </NavLink>
              <NavLink className="nav-link text-white" to="/profile">
                My Profile
              </NavLink>
              <button className="btn btn-light btn-sm" onClick={handleLogout}>
                Logout
              </button>
            </>
          ) : (
            <>
              <NavLink className="nav-link text-white" to="/login">
                Login
              </NavLink>
              <NavLink className="nav-link text-white" to="/register">
                Register
              </NavLink>
            </>
          )}
        </div>
      </div>
    </nav>
  );
}
