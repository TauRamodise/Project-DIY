using Microsoft.EntityFrameworkCore;
using Project_DIY.Models;

namespace Project_DIY.Data
{
    public class DiyDbContext : DbContext
    {
        public DiyDbContext(DbContextOptions<DiyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contract> Contracts { get; set; }
    }
}
