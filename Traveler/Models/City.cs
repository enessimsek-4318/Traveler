﻿namespace Traveler.Models
{
    public class City
    {
        public int cityId { get; set; }
        public string cityName { get; set; }
        public List<Post> posts { get; set; }
    }
}
