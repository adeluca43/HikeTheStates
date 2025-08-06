using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HikingApp.Models;

public class Comment
{
    public int Id { get; set; }

    [Required]
    public string Content { get; set; }

    public DateTime DatePosted { get; set; } = DateTime.UtcNow;

    [Required]
    public int HikeId { get; set; }

    public Hike? Hike { get; set; }

    [Required]
    public int UserProfileId { get; set; }

    public UserProfile? UserProfile { get; set; }
}
