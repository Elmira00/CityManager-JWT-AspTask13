using CityManager_JWT_task13.Entites;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CityManager_JWT_task13.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CityImage> CityImages { get; set; }
    }
}
