using MathProject.Models;
using Microsoft.EntityFrameworkCore;

namespace MathProject.Data
{
    public class MathDbContext : DbContext
    {
        public MathDbContext(DbContextOptions<MathDbContext> options) : base(options) 
        {
            
        }
        public DbSet<NumberInfo> Numbers { get; set; }

    }
}
