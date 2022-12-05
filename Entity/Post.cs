namespace Traveler.Entity
{
    public class Post
    {
        public int postId { get; set; }
        public string postDescription { get; set; }
        public int cityId { get; set; }
        public City city { get; set; }
        public List<Photo> photos { get; set; }
        public DateTime postDate { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public List<Comment> comments { get; set; }
        public List<Like> likes { get; set; }
    } 
}
