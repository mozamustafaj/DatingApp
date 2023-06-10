using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //Is going to used as a service in the app
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; } //if we leave them Users the table in db is called users
    }
}