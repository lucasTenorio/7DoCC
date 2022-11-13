using Challenge.Domain.Aggregates;

namespace Challenge.Domain.Interfaces.Aggregates
{
    public interface IVersionGroupDetail
    {
        int LevelLearnedAt { get; set; }
        MoveLearnMethod MoveLearnMethod { get; set; }
        VersionGroup VersionGroup { get; set; }
    }
}
