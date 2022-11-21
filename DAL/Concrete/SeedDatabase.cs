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
        private static Admin admin = new Admin
        {
            adminName="Enes",
            adminPassword="123"
        };
       public static void Seed()
        {
            var context =new DataContext();
            context.AddRange(admin);
        }
    }
}
