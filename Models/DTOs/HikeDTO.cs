namespace HikingApp.Models.DTOs;

public class HikeDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public double Distance { get; set; }
    public string Difficulty { get; set; }
    public bool IsDogFriendly { get; set; }

    public string UserFullName { get; set; }  // From UserProfile
}
