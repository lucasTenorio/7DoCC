using Challenge.Domain.Entities;
using Challenge.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class InteractController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(AnimalStatus), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAsync
            (
                [FromServices] IInteractWithPokemonService interactWithPokemonService
            )
        {
            var result = await interactWithPokemonService.CheckPokemonStatus();
            return Ok(result);
        }

        [HttpPatch("feed")]
        [ProducesResponseType(typeof(AnimalStatus), StatusCodes.Status202Accepted)]
        public async Task<IActionResult> FeedPokemonAsync(
                [FromServices] IInteractWithPokemonService interactWithPokemonService,
                [FromBody]AnimalStatus status
            )
        {
            try
            {
                var result = await interactWithPokemonService.Set(status).FeedPokemon();
                return Accepted(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("rest")]
        [ProducesResponseType(typeof(AnimalStatus), StatusCodes.Status202Accepted)]
        public async Task<IActionResult> PutToRestAsync(
                [FromServices] IInteractWithPokemonService interactWithPokemonService,
                [FromBody] AnimalStatus status
            )
        {
            try
            {
                var result = await interactWithPokemonService.Set(status).PutToRest();
                return Accepted(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("play")]
        [ProducesResponseType(typeof(AnimalStatus), StatusCodes.Status202Accepted)]
        public async Task<IActionResult> PostAsync(
                [FromServices] IInteractWithPokemonService interactWithPokemonService,
                [FromBody] AnimalStatus status
            )
        {
            try
            {
                var result = await interactWithPokemonService.Set(status).PlayWithPokemon();
                return Accepted(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
