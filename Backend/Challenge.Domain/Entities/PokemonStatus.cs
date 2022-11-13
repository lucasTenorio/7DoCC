using Challenge.Domain.Aggregates;
using Challenge.Domain.Interfaces.Entities;
using Challenge.Domain.Interfaces.ValueObject;
using System.Text.Json.Serialization;

namespace Challenge.Domain.Entities
{
    public class PokemonStatus : IPokemonStatus
    {
        public int Id { get; set; }

        public bool IsDefault { get; set; }
        [JsonPropertyName("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }
        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }

        public List<PokemonMove> Moves { get; set; }

        public List<Stats> Stats { get; set; }

        public List<Types> Types { get; set; }

        public List<Abilities> Abilities { get; set; }

        public List<Form> Forms { get; set; }

        [JsonPropertyName("game_indices")]
        public List<GameIndice> GameIndices { get; set; }

        public Species Species { get; set; }

        public PokemonStatus()
        {

        }
    }
}
