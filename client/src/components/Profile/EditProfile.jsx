import { useEffect, useState } from "react";
import {
  getUserProfile,
  updateUserProfile,
} from "../../managers/userProfileManager";
import { useNavigate } from "react-router-dom";

export default function EditProfile({ loggedInUser }) {
  // eslint-disable-next-line no-unused-vars
  const [profile, setProfile] = useState(null);
  const [formData, setFormData] = useState({
    firstName: "",
    lastName: "",
    email: "",
    imageLocation: "",
  });

  const navigate = useNavigate();

  useEffect(() => {
    getUserProfile(loggedInUser.id).then((profile) => {
      setFormData({
        firstName: profile.firstName || "",
        lastName: profile.lastName || "",
        email: profile.email || "",
        imageLocation: profile.imageLocation || "",
      });
    });
  }, [loggedInUser.id]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      await updateUserProfile(loggedInUser.id, formData);
      navigate("/profile");
    } catch (error) {
      console.error("Failed to update profile:", error);
    }
  };

  return (
    <div className="container mt-4">
      <h2>Edit Your Profile</h2>
      <form onSubmit={handleSubmit}>
        <div className="mb-3">
          <label>First Name</label>
          <input
            name="firstName"
            className="form-control"
            value={formData.firstName}
            onChange={handleChange}
            required
          />
        </div>

        <div className="mb-3">
          <label>Last Name</label>
          <input
            name="lastName"
            className="form-control"
            value={formData.lastName}
            onChange={handleChange}
            required
          />
        </div>

        <div className="mb-3">
          <label>Email</label>
          <input
            name="email"
            type="email"
            className="form-control"
            value={formData.email}
            onChange={handleChange}
            required
          />
        </div>

        <div className="mb-3">
          <label>Profile Image URL</label>
          <input
            name="imageLocation"
            className="form-control"
            value={formData.imageLocation}
            onChange={handleChange}
          />
        </div>

        <button className="btn btn-primary">Save Changes</button>
      </form>
    </div>
  );
}
