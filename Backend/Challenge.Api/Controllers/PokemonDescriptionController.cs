using Challenge.Domain.Entities;
using Challenge.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [AllowAnonymous]
    [Route("Api/[controller]")]
    public class PokemonDescriptionController : Controller
    {
       [HttpGet]
        [ProducesResponseType(400)]
        [ProducesResponseType(typeof(PokemonStatus), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAsync(
           [FromServices] IPokeServices pokeServices,
           int filter)
        {
            if (filter == 0)
                return BadRequest();

            var result = await pokeServices
                .SetFilter(filter)
                .GetPokemonById();
            
            return Ok(result);

        }  
    }
}
