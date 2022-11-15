using Challenge.Domain.Aggregates;
using Challenge.Domain.Interfaces.Aggregates;
using Challenge.Domain.Interfaces.Entities;

namespace Challenge.Domain.Entities
{
    public class Pokedex : IPokedex
    {
        public int Count { get; set; }

        public string? Next { get; set; }

        public string? Previous { get; set; }

        public List<PokeShortDescription> Results { get; set; } = new List<PokeShortDescription>();

        public Pokedex(int count, string next, string previous, List<PokeShortDescription> results)
        {
            Count = count;
            Next = next; 
            Previous = previous;
            Results = results;
        }
        public Pokedex() { }
    }
}
