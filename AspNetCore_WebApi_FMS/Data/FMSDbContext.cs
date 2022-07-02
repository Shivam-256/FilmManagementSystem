using AspNetCore_WebApi_FMS.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_WebApi_FMS.Data
{
    public class FMSDbContext : DbContext
    {
        public FMSDbContext(DbContextOptions<FMSDbContext> options) : base(options)
        {
            
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
