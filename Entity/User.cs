namespace Traveler.Entity
{
    public class User
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public bool isActive { get; set; }
        public List<Like> likes { get; set; }
        public List<Comment> comments { get; set; }

    }
}
