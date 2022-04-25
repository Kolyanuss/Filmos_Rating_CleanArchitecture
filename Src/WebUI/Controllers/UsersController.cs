using Filmos_Rating_CleanArchitecture.Application.User.Queries.GetUsersList;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Filmos_Rating_CleanArchitecture.WebUI.Controllers
{
    public class UsersController : BaseController
    {
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<UsersListVm>> GetAll()
        {
            return Ok(await Mediator.Send(new GetUsersListQuery()));
        }
    }
}
