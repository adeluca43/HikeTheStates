using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HikingApp.Models;

public class Hike
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Location { get; set; }

    [Required]
    public double Distance { get; set; }

    [Required]
    public bool IsDogFriendly { get; set; }

    [Required]
    public int UserProfileId { get; set; }

    public UserProfile UserProfile { get; set; }

    [Required]
    public int DifficultyId { get; set; }
    public Difficulty Difficulty { get; set; }
}
