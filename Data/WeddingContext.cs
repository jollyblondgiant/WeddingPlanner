using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;
namespace WeddingPlanner.Data
{
    public class WeddingContext : DbContext
    {
        public WeddingContext(DbContextOptions<WeddingContext> options) : base(options){}

        public DbSet<RSVP> RSVPs{get;set;}
        public DbSet<User> Users{get;set;}
        public DbSet<Wedding> Weddings{get;set;}
    }
}