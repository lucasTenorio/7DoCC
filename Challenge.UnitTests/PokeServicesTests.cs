using Challenge.Domain.Interfaces.Entities;
using Challenge.Domain.Services;
using Challenge.Infrastructure;
using Challenge.Services;
using Moq;
using Xunit;

namespace Challenge.UnitTests
{
    public class PokeServicesTests
    {
        private readonly PokeServices _sut;
        private readonly Mock<HttpClient> _httpClientSpy = new ();
        private readonly Mock<PokeEndpoints> _pokeEndpointsSpy = new ();
        private readonly Mock<IApiResult> _apiResultDummy = new();
        private readonly Mock<ILogger<PokeServices>> _loggerSpy = new();

        private const string DummyUrl = "url";
        public PokeServicesTests()
        {
            _sut = new PokeServices(_httpClientSpy.Object, _pokeEndpointsSpy.Object, _loggerSpy.Object);
        }

        [Fact]
        private async void ShouldReturnApiResult()
        {
            //_httpClientSpy.Setup(client => client.GetFromJsonAsync<IApiResult>(DummyUrl, It.IsAny<CancellationToken>())).ReturnsAsync(_apiResultDummy.Object);
            var result = await _sut.GetApiResultAsync();
            Assert.IsAssignableFrom<IApiResult>(result);
        }

    }
}
