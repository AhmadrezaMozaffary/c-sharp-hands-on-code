using Microsoft.EntityFrameworkCore;
using SecondCourseProject.Models;

namespace FithCourseProject.Data.Context
{
    public class FifthDbContext : DbContext
    {
        public FifthDbContext(DbContextOptions<FifthDbContext> options) : base(options)
        {
        }

        public DbSet<FriendModel> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  
        }
    }
}
