using Challenge.Domain.Interfaces.Aggregates;
using System.Text.Json.Serialization;

namespace Challenge.Domain.Aggregates
{
    public class Stats : IStats
    {
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }

        public int Effort {get; set; }

        public Stat Stat { get; set; } = new Stat(); 
    }
}
