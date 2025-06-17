namespace HikingApp.Models
{
    public class HikeLike
    {
        public int Id { get; set; }

        public int HikeId { get; set; }
        public Hike Hike { get; set; }

        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
