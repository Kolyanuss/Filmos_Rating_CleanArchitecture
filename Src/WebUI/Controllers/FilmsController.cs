﻿using Filmos_Rating_CleanArchitecture.Application.Film.Queries.GetFilmsList;
using Filmos_Rating_CleanArchitecture.Application.Film.Queries.GetFilmById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Filmos_Rating_CleanArchitecture.Application.Film.Commands.DeleteFilms;
using Filmos_Rating_CleanArchitecture.Application.Film.Commands.UpsertFilms;

namespace Filmos_Rating_CleanArchitecture.WebUI.Controllers
{
    public class FilmsController : BaseController
    {
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FilmsListVm>> GetAll()
        {
            return Ok(await Mediator.Send(new GetFilmsListQuery()));
        }

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FilmsLookupDto>> GetById(GetFilmQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Upsert(UpsertFilmCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string? id)
        {
            await Mediator.Send(new DeleteFilmsCommand { Id = id });

            return NoContent();
        }
    }
}
