using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmos_Rating_CleanArchitecture.Application.Film.Commands.DeleteFilms
{
    public class DeleteFilmsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
