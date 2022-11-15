using Challenge.Domain.Interfaces.Aggregates;
using System.Text.Json.Serialization;

namespace Challenge.Domain.Aggregates
{
    public class GameIndice : IGameIndice
    {
        [JsonPropertyName("game_index")]
        public int gameIndex { get; set; }
        public Version Version { get; set; } = new Version();
    }
}
