using Challenge.Domain.Entities;
using Challenge.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [AllowAnonymous]
    [Route("Api/[controller]")]
    public class PokeController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(ApiResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetAsync(
            [FromServices] IPokeServices pokeServices,
            string filter
            )
        {
            if (!string.IsNullOrWhiteSpace(filter))
            {
                pokeServices.SetFilter(filter);
            }
            var result = await pokeServices.GetApiResultAsync();
            return Ok(result);
        }
    }
}
