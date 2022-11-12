namespace Challenge.Infrastructure
{
    public class PokeEndpoints
    {
        private const string _pokeEndpointLists = "https://pokeapi.co/api/v2/pokemon/";

        public string GetListEndpoint() => _pokeEndpointLists;  
    }
}
