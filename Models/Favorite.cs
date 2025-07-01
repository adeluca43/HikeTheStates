
using HikingApp.Models;
public class Favorite
{
    public int Id { get; set; }

    public int UserProfileId { get; set; }

    public int HikeId { get; set; }

    public DateTime DateFavorited { get; set; } = DateTime.Now;

    public UserProfile UserProfile { get; set; }

    public Hike Hike { get; set; }
}
