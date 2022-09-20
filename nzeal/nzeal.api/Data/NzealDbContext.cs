using Microsoft.EntityFrameworkCore;
using nzeal.api.Models.Domain;

namespace nzeal.api.Data
{
    public class NzealDbContext : DbContext
    {
        public NzealDbContext(DbContextOptions<NzealDbContext> options): base(options)  
        {

        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }




    }

}
