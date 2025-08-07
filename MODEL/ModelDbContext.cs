using Microsoft.EntityFrameworkCore;
using Models.Entity;

namespace MODEL
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext()
        { }

        public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=141.98.112.152;Database=Codebucks;User Id=Nevers;Password=Nevers231_;TrustServerCertificate=True;");
            }
        }

        public DbSet<User> Users { get; set; }
    }
}