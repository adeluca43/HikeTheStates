using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HikingApp.Models;

public class UserProfile
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public string Email { get; set; }
    public string IdentityUserId { get; set; }
    public IdentityUser IdentityUser { get; set; }
    public string? ImageLocation { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public List<Hike> Hikes { get; set; } = new List<Hike>();

}
