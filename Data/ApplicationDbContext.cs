using Microsoft.EntityFrameworkCore;
using LongDrive.Models;

namespace LongDrive.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Soiduauto> Soiduautod { get; set; }
        public DbSet<Veoauto> Veoautod { get; set; }
        public DbSet<Tellimus> Tellimused { get; set; }
        public DbSet<SoiduPaevik> SoiduPaevikud { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}