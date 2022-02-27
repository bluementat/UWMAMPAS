using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWMAMPAS.Data.Models;

namespace UWMAMPAS.Data
{
    public class AcademyDbContext : DbContext
    {
        public DbSet<Performer> Performers => Set<Performer>();
        public DbSet<Movie> Movies => Set<Movie>();

        public AcademyDbContext(DbContextOptions<AcademyDbContext> options ) : base( options )      
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Performer>()
                .HasKey( x => x.PerformerId );

            modelBuilder.Entity<Movie>()
                .HasKey( x => x.MovieId );
        }

    }
}
