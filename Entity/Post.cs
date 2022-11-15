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
    }
}
