import { useEffect, useState } from "react";
import {
  getCommentsByHikeId,
  addComment,
  deleteComment,
} from "../managers/commentManager";

export default function CommentList({ hikeId, loggedInUser }) {
  const [comments, setComments] = useState([]);
  const [newComment, setNewComment] = useState("");

  const userProfileId = loggedInUser.id;

  // Load comments for this hike
  useEffect(() => {
    getCommentsByHikeId(hikeId).then(setComments);
  }, [hikeId]);

  // Add a new comment
  const handleSubmit = async (e) => {
    e.preventDefault();
    if (newComment.trim() === "") return;

    const newCommentObj = {
      // Your API model accepts PascalCase (ASP.NET is case-insensitive for JSON),
      // keeping Content to match your existing code.
      Content: newComment,
      hikeId,
      userProfileId,
    };

    try {
      const response = await addComment(newCommentObj);
      if (response.ok) {
        const refreshed = await getCommentsByHikeId(hikeId);
        setComments(refreshed);
        setNewComment("");
      } else {
        alert("Error posting comment.");
      }
    } catch (err) {
      console.error(err);
      alert("Error posting comment.");
    }
  };

  // Delete a comment (only if it's mine)
  const handleDelete = async (commentId) => {
    if (!window.confirm("Delete this comment?")) return;
    try {
      await deleteComment(commentId);
      const refreshed = await getCommentsByHikeId(hikeId);
      setComments(refreshed);
    } catch (err) {
      console.error(err);
      alert("Could not delete comment.");
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
          {comments.map((comment) => {
            // From your CommentDTO -> camelCase JSON: id, userId, firstName, lastName, content, datePosted
            const isMine = comment.userId === loggedInUser.id;

            return (
              <li
                key={comment.id}
                className="mb-2 d-flex justify-content-between align-items-start"
              >
                <div>
                  <strong>
                    {comment.firstName} {comment.lastName}:
                  </strong>{" "}
                  {comment.content}
                  <br />
                  <small className="text-muted">
                    {new Date(comment.datePosted).toLocaleString()}
                  </small>
                </div>

                {isMine && (
                  <button
                    type="button"
                    className="btn btn-sm btn-outline-danger ms-2"
                    onClick={() => handleDelete(comment.id)}
                    title="Delete comment"
                  >
                    🗑️
                  </button>
                )}
              </li>
            );
          })}
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
