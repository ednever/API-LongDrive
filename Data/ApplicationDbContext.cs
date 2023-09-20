using Microsoft.EntityFrameworkCore;
using LongDrive.Models;

namespace LongDrive.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Tellimus> Tellimused { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}