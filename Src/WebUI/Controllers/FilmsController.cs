using Filmos_Rating_CleanArchitecture.Application.Film.Queries.GetFilmsList;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Filmos_Rating_CleanArchitecture.WebUI.Controllers
{
    public class FilmsController : BaseController
    {
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<FilmsListVm>> GetAll()
        {
            return Ok(await Mediator.Send(new GetFilmsListQuery()));
        }
/*
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Upsert(UpsertFilmsCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteFilmsCommand { Id = id });

            return NoContent();
        }*/
    }
}
