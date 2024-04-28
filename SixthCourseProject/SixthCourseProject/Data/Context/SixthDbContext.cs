using Microsoft.EntityFrameworkCore;
using SixthCourseProject.Models;

namespace SixthCourseProject.Data.Context
{
    public class SixthDbContext : DbContext
    {
        public SixthDbContext(DbContextOptions<SixthDbContext> options) : base(options)
        {
        }

        public DbSet<FriendModel> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  
        }
    }
}
