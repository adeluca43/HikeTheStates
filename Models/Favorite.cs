
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


using HikingApp.Models;
public class Favorite
{
    public int Id { get; set; }

    [Required]
    public int UserProfileId { get; set; }

    [Required]
    public int HikeId { get; set; }

    public DateTime DateFavorited { get; set; } = DateTime.Now;

    [JsonIgnore]
    public UserProfile? UserProfile { get; set; }

    [JsonIgnore]
    public Hike? Hike { get; set; }
}