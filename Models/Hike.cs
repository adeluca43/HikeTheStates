using System.ComponentModel.DataAnnotations;

namespace HikingApp.Models;

public class Hike
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string AddressLine1 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    [Required]
    public double Distance { get; set; }
    [Required]
    public bool IsDogFriendly { get; set; }
    public bool IsKidFriendly { get; set; }
    public bool IsHandicapAccessible { get; set; }
    public bool HasRestrooms { get; set; }
    public bool IsPaved { get; set; }
    public bool IsGravel { get; set; }
    [Required]
    public int UserProfileId { get; set; }
    public UserProfile UserProfile { get; set; }
    [Required]
    public int DifficultyId { get; set; }
    public Difficulty Difficulty { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

}

