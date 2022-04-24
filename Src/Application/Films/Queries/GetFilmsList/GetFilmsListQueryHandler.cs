using AutoMapper;
using MediatR;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Filmos_Rating_CleanArchitecture.Application.Films.Queries.GetFilmsList
{
    public class GetFilmsListQueryHandler : IRequestHandler<GetFilmsListQuery, FilmsListVm>
    {
        //private readonly IFilmosDbContext _context;
        private readonly IMapper _mapper;

        public GetFilmsListQueryHandler(/*IFilmosDbContext context, */IMapper mapper)
        {
            //_context = context;
            _mapper = mapper;
        }

        public async Task<FilmsListVm> Handle(GetFilmsListQuery request, CancellationToken cancellationToken)
        {
            var temp = new List<FilmsLookupDto>
            {
                new FilmsLookupDto(0, "Test")
            };
            var vm = new FilmsListVm
            {
                Films = temp
            };

            return vm;
        }
    }
}
