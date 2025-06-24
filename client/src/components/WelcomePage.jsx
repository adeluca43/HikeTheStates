import { Link } from "react-router-dom";
import { Container } from "react-bootstrap";
import logo from "../assets/images/logo hikethestates.png";

export default function WelcomePage() {
  return (
    <Container
      className="d-flex flex-column align-items-center justify-content-center"
      style={{ height: "100vh", textAlign: "center" }}
    >
      <Link to="/home">
        <img
          src={logo}
          alt="HikeTheStates Logo"
          style={{
            maxWidth: "100%",
            height: "auto",
            cursor: "pointer",
            borderRadius: "8px",
            boxShadow: "0 4px 20px rgba(0, 0, 0, 0.2)",
          }}
        />
      </Link>
    </Container>
  );
}
