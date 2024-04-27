using Microsoft.EntityFrameworkCore;

namespace Rooydaad.Web.Data.Context
{
    public class RooydaadDbContext : DbContext
    {
        public RooydaadDbContext(DbContextOptions<RooydaadDbContext> options): base(options)
        {
            
        }

        DbSet<Event> Events { get; set; }
    }
}
