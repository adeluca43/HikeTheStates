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

    // Optional: Concatenated full name (not stored in DB)
    public string FullName => $"{FirstName} {LastName}";
}
