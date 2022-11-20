namespace Challenge.Domain.Interfaces.Aggregates
{
    public interface IPokeShortDescription
    {
        public string Name { get; }
        public string Url { get; }
        public int PokemonId { get; }
    }
}
