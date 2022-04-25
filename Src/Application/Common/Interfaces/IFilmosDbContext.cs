using Filmos_Rating_CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Filmos_Rating_CleanArchitecture.Application.Common.Interfaces
{
    public interface IFilmosDbContext
    {
        DbSet<Films> Films { get; set; }
        DbSet<Users> Users { get; set; }
        DbSet<Comment> Comments { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
