namespace HikingApp.Models.DTOs;

public class CreateHikeDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public double Distance { get; set; }
    public int DifficultyId { get; set; }
    public bool IsDogFriendly { get; set; }
    public int UserProfileId { get; set; }
}
