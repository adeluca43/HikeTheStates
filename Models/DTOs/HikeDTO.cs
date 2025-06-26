namespace HikingApp.Models.DTOs;

public class HikeDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string AddressLine1 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public double Distance { get; set; }
    public string Difficulty { get; set; }
    public bool IsDogFriendly { get; set; }
    public bool IsKidFriendly { get; set; }
    public bool IsHandicapAccessible { get; set; }
    public bool HasRestrooms { get; set; }
    public bool IsPaved { get; set; }
    public bool IsGravel { get; set; }
    public string UserFullName { get; set; }
    public DateTime DateCreated { get; set; }
    public int UserProfileId { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

}
