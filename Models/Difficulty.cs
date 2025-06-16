namespace HikingApp.Models;

public class Difficulty
{
    public int Id { get; set; }
    public string Level { get; set; }
    public List<Hike> Hikes { get; set; } = new();
}
