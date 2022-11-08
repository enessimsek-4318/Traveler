using System.Reflection.Metadata.Ecma335;

namespace Traveler.Models
{
    public class Comment
    {
        public int commentId { get; set; }
        public string commentDetail { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public int postId { get; set; }
        public Post post { get; set; }

    }
}
