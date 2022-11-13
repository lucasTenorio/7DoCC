using Challenge.Domain.Entities;
using Challenge.Domain.Interfaces.Entities;

namespace Challenge.Domain.Services
{
    public interface IPokeServices
    {
        IPokeServices SetFilter(int filter);
        Task<Pokedex> GetApiResultAsync();
        Task<PokemonStatus> GetPokemonById();
    }
}
