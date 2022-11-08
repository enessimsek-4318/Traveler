namespace Traveler.Models
{
    public class Like
    {
        public int likeId { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public int postId { get; set; }
        public Post post { get; set; }
    }
}
