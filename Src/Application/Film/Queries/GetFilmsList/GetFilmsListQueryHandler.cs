using AutoMapper;
using AutoMapper.QueryableExtensions;
using Filmos_Rating_CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Filmos_Rating_CleanArchitecture.Application.Film.Queries.GetFilmsList
{
    public class GetUsersListQueryHandler : IRequestHandler<GetFilmsListQuery, FilmsListVm>
    {
        private readonly IFilmosDbContext _context;
        private readonly IMapper _mapper;

        public GetUsersListQueryHandler(IFilmosDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<FilmsListVm> Handle(GetFilmsListQuery request, CancellationToken cancellationToken)
        {
            /*var films = await _context.Films
                .ProjectTo<FilmsLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);*/

            var tempfilm = new FilmsLookupDto();
            tempfilm.Id = 0;
            tempfilm.Name = "It is test";
            var temp = new List<FilmsLookupDto>
            {
                tempfilm
            };

            var vm = new FilmsListVm
            {
                //Films = films
                Films = temp
            };

            return vm;
        }
    }
}
