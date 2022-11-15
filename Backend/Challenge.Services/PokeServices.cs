using Challenge.Domain.Entities;
using Challenge.Domain.Services;
using Challenge.Infrastructure;


namespace Challenge.Services
{
    public class PokeServices : IPokeServices
    {
        private int _filter;
        private readonly HttpClient _httpClient;
        private readonly PokeEndpoints _pokeEndpoints;
        private readonly ILogger<PokeServices> _iLogger;

        public PokeServices(HttpClient httpClientBuilder, PokeEndpoints pokeEndpoints, ILogger<PokeServices> iLogger)
        {
            _httpClient = httpClientBuilder;
            _pokeEndpoints = pokeEndpoints;
            _iLogger = iLogger;
        }

        public async Task<Pokedex> GetApiResultAsync()
        {
            try
            {
                var endpoint = _pokeEndpoints.GetListEndpoint();
                var list = await _httpClient.GetFromJsonAsync<Pokedex>(endpoint);
                if (list == null) throw new BadHttpRequestException("The requests returned empty", StatusCodes.Status400BadRequest);
                return list;

            }catch(Exception ex)
            {
                _iLogger.LogError(message: ex.Message, ex);
                return new Pokedex();
            }
            finally { 
                _httpClient.Dispose();
            }
        }

        public IPokeServices SetFilter(int filter)
        {
            _filter = filter;
            return this;
        }

        public async Task<PokemonStatus> GetPokemonById()
        {
            if (_filter == 0) throw new ArgumentException(nameof(_filter));

            var endpoint = _pokeEndpoints.GetListEndpoint();
            var list = await _httpClient.GetFromJsonAsync<PokemonStatus>(endpoint + _filter.ToString());
            if (list == null) throw new BadHttpRequestException("The request returned empty", StatusCodes.Status400BadRequest);
            return list;
        }
    }
}
