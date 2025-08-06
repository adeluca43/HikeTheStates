import { useEffect, useState } from "react";

export default function CommentList({ hikeId }) {
  const [comments, setComments] = useState([]);

  useEffect(() => {
    fetch(`http://localhost:5000/api/comments/hike/${hikeId}`)
      .then((res) => res.json())
      .then(setComments);
  }, [hikeId]);

  return (
    <div className="comment-section">
      <h4>Comments</h4>
      {comments.length === 0 ? (
        <p>No comments yet. Be the first to comment!</p>
      ) : (
        <ul>
          {comments.map((comment) => (
            <li key={comment.id}>
              <strong>{comment.user?.firstName || "Anonymous"}:</strong>{" "}
              {comment.content}
              <br />
              <small>{new Date(comment.datePosted).toLocaleString()}</small>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
}
