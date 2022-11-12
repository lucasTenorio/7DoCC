using Challenge.Domain.Entities;
using Challenge.Domain.Interfaces.Entities;
using Challenge.Domain.Services;
using Challenge.Infrastructure;
using Microsoft.Extensions.Options;

namespace Challenge.Services
{
    public class PokeServices : IPokeServices
    {
        private string _filter;
        private readonly HttpClient _httpClient;
        private readonly PokeEndpoints _pokeEndpoints;
        private readonly ILogger<PokeServices> _iLogger;

        public PokeServices(HttpClient httpClientBuilder, PokeEndpoints pokeEndpoints, ILogger<PokeServices> iLogger)
        {
            _httpClient = httpClientBuilder;
            _pokeEndpoints = pokeEndpoints;
            _iLogger = iLogger;
        }

        public async Task<ApiResult> GetApiResultAsync()
        {
            try
            {
                var endpoint = _pokeEndpoints.GetListEndpoint() +
                    (string.IsNullOrWhiteSpace(_filter) ? "" : _filter);
                var list = await _httpClient.GetFromJsonAsync<ApiResult>(endpoint);
                if (list == null) throw new BadHttpRequestException("The requests returned empty", StatusCodes.Status400BadRequest);
                return list;

            }catch(Exception ex)
            {
                _iLogger.LogError(ex.Message, ex);
                return null;
            }
            finally { 
                _httpClient.Dispose();
            }
        }

        public IPokeServices SetFilter(string filter)
        {
            _filter = filter;
            return this;
        }
    }
}
