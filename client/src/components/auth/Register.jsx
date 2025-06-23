import { useState } from "react";
import { register } from "../../managers/authManager";
import { Link, useNavigate } from "react-router-dom";
import { Button, FormFeedback, FormGroup, Input, Label } from "reactstrap";

export default function Register({ setLoggedInUser }) {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [imageLocation, setImageLocation] = useState("");
  const [imageMissing, setImageMissing] = useState(false);
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [errors, setErrors] = useState([]);

  const [passwordMismatch, setPasswordMismatch] = useState();

  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();

    if (!imageLocation.trim()) {
      setImageMissing(true);
      return;
    }

    if (password !== confirmPassword) {
      setPasswordMismatch(true);
      return;
    }

    const newUser = {
      firstName,
      lastName,
      email,
      password,
      imageLocation,
    };

    register(newUser).then((user) => {
      if (user.errors) {
        const errorsArray = Array.isArray(user.errors)
          ? user.errors
          : [user.errors];
        setErrors(errorsArray);
      } else {
        setLoggedInUser(user);
        navigate("/");
      }
    });
  };
  return (
    <div className="container" style={{ maxWidth: "500px" }}>
      <h3>Sign Up</h3>
      <FormGroup>
        <Label>First Name</Label>
        <Input
          type="text"
          autoComplete="given-name"
          value={firstName}
          onChange={(e) => setFirstName(e.target.value)}
        />
      </FormGroup>
      <FormGroup>
        <Label>Last Name</Label>
        <Input
          type="text"
          autoComplete="family-name"
          value={lastName}
          onChange={(e) => setLastName(e.target.value)}
        />
      </FormGroup>
      <FormGroup>
        <Label>Image URL</Label>
        <Input
          type="text"
          invalid={imageMissing}
          value={imageLocation}
          onChange={(e) => {
            setImageMissing(false);
            setImageLocation(e.target.value);
          }}
        />
        <FormFeedback>Image URL is required.</FormFeedback>
      </FormGroup>
      <FormGroup>
        <Label>Email</Label>
        <Input
          type="email"
          autoComplete="email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
      </FormGroup>
      <FormGroup>
        <Label>Password</Label>
        <Input
          type="password"
          autoComplete="new-password"
          invalid={passwordMismatch}
          value={password}
          onChange={(e) => {
            setPasswordMismatch(false);
            setPassword(e.target.value);
          }}
        />
      </FormGroup>
      <FormGroup>
        <Label>Confirm Password</Label>
        <Input
          type="password"
          autoComplete="new-password"
          invalid={passwordMismatch}
          value={confirmPassword}
          onChange={(e) => {
            setPasswordMismatch(false);
            setConfirmPassword(e.target.value);
          }}
        />
        <FormFeedback>Passwords do not match!</FormFeedback>
      </FormGroup>

      {errors.map((e, i) => (
        <p key={i} style={{ color: "red" }}>
          {e}
        </p>
      ))}
      <Button
        color="primary"
        onClick={handleSubmit}
        disabled={passwordMismatch}
      >
        Register
      </Button>
      <p>
        Already signed up? Log in <Link to="/login">here</Link>
      </p>
    </div>
  );
}
