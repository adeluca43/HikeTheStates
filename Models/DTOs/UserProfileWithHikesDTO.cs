namespace HikingApp.Models.DTOs;

public class UserProfileWithHikesDTO
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string? ImageLocation { get; set; }
    public string Email { get; set; }
    public List<HikeDTO> Hikes { get; set; }
}
