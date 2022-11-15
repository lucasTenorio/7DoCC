using Challenge.Domain.Interfaces.Aggregates;
using System.Text.Json.Serialization;

namespace Challenge.Domain.Aggregates
{
    public class PokemonMove : IMove
    {
        public PokemonMove()
        {
        }
        [JsonPropertyName("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; } = new List<VersionGroupDetail>();

        public MoveDescription Move { get; set; } = new MoveDescription();  

    }
}
