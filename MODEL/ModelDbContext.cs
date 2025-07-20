using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=141.98.112.152;Database=Codebucks;User Id=Nevers;Password=Nevers231_;TrustServerCertificate=True;");
            }
        }

        public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
        {
        }
    }
}