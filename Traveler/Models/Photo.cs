namespace Traveler.Models
{
    public class Photo
    {
        public int photoId { get; set; }
        public string photoUrl { get; set; }
        public int postId { get; set; }
        public Post post { get; set; }
    }
}
