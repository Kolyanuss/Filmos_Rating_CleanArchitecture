using Filmos_Rating_CleanArchitecture.Application.Common.Interfaces;
using Filmos_Rating_CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Filmos_Rating_CleanArchitecture.Persistence
{
    public class FilmosDbContext : DbContext, IFilmosDbContext
    {
        public DbSet<Films> Films { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public FilmosDbContext(DbContextOptions options) : base(options)
        { }

        //Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FilmosDbContext).Assembly);
        }
    }
}
