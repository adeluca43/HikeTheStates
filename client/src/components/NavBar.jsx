import { NavLink, useNavigate } from "react-router-dom";
import { logout } from "../managers/authManager";
import { Navbar, Nav, Container, Button } from "react-bootstrap";
import logo from "../assets/images/logo hikethestates.png";

export default function NavBar({ loggedInUser, setLoggedInUser }) {
  const navigate = useNavigate();

  const handleLogout = () => {
    logout().then(() => {
      setLoggedInUser(null);
      navigate("/login");
    });
  };

  return (
    <Navbar bg="success" variant="dark" expand="md" className="px-3">
      <Container fluid>
        <Navbar.Brand className="text-white fw-bold d-flex align-items-center">
          <img
            src={logo}
            alt="HikeTheStates Logo"
            width="80"
            height="60"
            className="me-2"
          />
          {loggedInUser && <>Welcome, {loggedInUser.firstName}</>}
        </Navbar.Brand>

        <Navbar.Toggle aria-controls="navbar-content" />
        <Navbar.Collapse id="navbar-content" className="justify-content-end">
          <Nav className="gap-3">
            {loggedInUser ? (
              <>
                <NavLink className="nav-link text-white" to="/home">
                  Home
                </NavLink>
                <NavLink className="nav-link text-white" to="/hikes/new">
                  Add Hike
                </NavLink>
                <NavLink className="nav-link text-white" to="/profile">
                  My Profile
                </NavLink>
                <NavLink className="nav-link text-white" to="/favorites">
                  Favorites
                </NavLink>
                <Button
                  variant="light"
                  size="sm"
                  onClick={handleLogout}
                  className="align-self-center"
                >
                  Logout
                </Button>
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
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}
