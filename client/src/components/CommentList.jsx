import { useEffect, useState } from "react";
import { getCommentsByHikeId, addComment } from "../managers/commentManager";

export default function CommentList({ hikeId, loggedInUser }) {
  const [comments, setComments] = useState([]);
  const [newComment, setNewComment] = useState("");

  const userProfileId = loggedInUser.id;

  useEffect(() => {
    getCommentsByHikeId(hikeId).then(setComments);
  }, [hikeId]);

  const handleSubmit = async (e) => {
    e.preventDefault();
    if (newComment.trim() === "") return;

    const newCommentObj = {
      Content: newComment,
      hikeId,
      userProfileId,
    };

    const response = await addComment(newCommentObj);
    if (response.ok) {
      getCommentsByHikeId(hikeId).then(setComments);
      setNewComment("");
    } else {
      alert("Error posting comment.");
    }
  };

  return (
    <div
      className="mt-4 pt-2 px-3"
      style={{
        borderTop: "2px solid black",
        backgroundColor: "#f8f9fa",
        fontSize: "0.9rem",
        borderRadius: "5px",
      }}
    >
      <h6 className="fw-bold mb-2">Comments</h6>
      {comments.length === 0 ? (
        <p className="text-muted mb-2">No comments yet.</p>
      ) : (
        <ul className="list-unstyled mb-2">
          {comments.map((comment) => (
            <li key={comment.id} className="mb-2">
              <strong>
                {comment.firstName} {comment.lastName}:
              </strong>{" "}
              {comment.content}
              <br />
              <small className="text-muted">
                {new Date(comment.datePosted).toLocaleString()}
              </small>
            </li>
          ))}
        </ul>
      )}

      <form onSubmit={handleSubmit}>
        <div className="mb-2">
          <textarea
            className="form-control"
            rows="2"
            placeholder="Write a comment..."
            value={newComment}
            onChange={(e) => setNewComment(e.target.value)}
          />
        </div>
        <button type="submit" className="btn btn-sm btn-dark">
          Post Comment
        </button>
      </form>
    </div>
  );
}
