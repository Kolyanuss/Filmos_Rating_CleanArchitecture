using MediatR;

namespace Filmos_Rating_CleanArchitecture.Application.Films.Queries.GetFilmsList
{
    public class GetFilmsListQuery : IRequest<FilmsListVm>
    {
    }
}
