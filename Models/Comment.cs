using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HikingApp.Models;

public class Comment
{
    public int Id { get; set; }

    public string Content { get; set; }

    public DateTime DatePosted { get; set; } = DateTime.UtcNow;

    public int HikeId { get; set; }
    public Hike Hike { get; set; }

    public int UserId { get; set; }
    public UserProfile UserProfile { get; set; }  // Replace with your actual User model class name if different
}
