using AutoMapper;
using AutoMapper.QueryableExtensions;
using Filmos_Rating_CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using Filmos_Rating_CleanArchitecture.Domain.Entities;

namespace Filmos_Rating_CleanArchitecture.Application.User.Queries.GetUsersList
{
    public class GetUsersListQueryHandler : IRequestHandler<GetUsersListQuery, UsersListVm>
    {
        private readonly IFilmosDbContext _context;
        private readonly IMapper _mapper;
        IGridFSBucket gridFS;   // файловое хранилище
        IMongoCollection<Users> Users; // коллекция в базе данных

        public GetUsersListQueryHandler(IFilmosDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

            // строка подключения
            string connectionString = "mongodb://localhost:27017/filmos_rating";
            var connection = new MongoUrlBuilder(connectionString);
            // получаем клиента для взаимодействия с базой данных
            MongoClient client = new MongoClient(connectionString);
            // получаем доступ к самой базе данных
            IMongoDatabase database = client.GetDatabase(connection.DatabaseName);
            // получаем доступ к файловому хранилищу
            gridFS = new GridFSBucket(database);
            // обращаемся к коллекции
            Users = database.GetCollection<Users>("Users");
        }

        public async Task<UsersListVm> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            var ListUser = await Users.Find(_ => true).ToListAsync();
            var ListUserDto = _mapper.Map<List<UsersLookupDto>>(ListUser);

            var vm = new UsersListVm
            {
                //Films = films
                Users = ListUserDto
            };

            return vm;
        }
    }
}
