using Microsoft.EntityFrameworkCore;
using MvcSpoon.Models;

namespace MvcSpoon.Data
{
    public class MvcSpoonContext : DbContext
    {
        public MvcSpoonContext(DbContextOptions<MvcSpoonContext> options)
            : base(options)
        {
        }

        public DbSet<Spoon> Spoon { get; set; }
    }
}