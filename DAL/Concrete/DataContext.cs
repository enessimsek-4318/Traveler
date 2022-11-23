using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Traveler.Entity;

namespace DAL.Concrete
{
    public class DataContext : DbContext
    {
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UVMSNSF;Initial Catalog=Traveler;Integrated Security=True");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
