using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveler.Entity;

namespace DAL.Concrete
{
    public static class SeedDatabase
    {

        public static void Seed()
        {
            var context =new DataContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Admins.Count()==0)
                {
                    context.Admins.AddRange(admin);
                }
                context.SaveChanges();
            }
        }
        private static Admin admin = new Admin()
        {
            adminName = "Enes",
            adminPassword = "1"
        };
    }
}
