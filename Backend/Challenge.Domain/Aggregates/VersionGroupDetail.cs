using Challenge.Domain.Interfaces.Aggregates;
using System.Text.Json.Serialization;

namespace Challenge.Domain.Aggregates
{
    public class VersionGroupDetail : IVersionGroupDetail
    {
        [JsonPropertyName("level_learned_at")]
        public int LevelLearnedAt { get ; set; }
        [JsonPropertyName("move_learn_method")]
        public MoveLearnMethod MoveLearnMethod { get; set; }
        [JsonPropertyName("version_group")]
        public VersionGroup VersionGroup { get; set; }

    }
}
