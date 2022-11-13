using Challenge.Domain.Aggregates;

namespace Challenge.Domain.Interfaces.Aggregates
{
    public interface IMove
    {
        List<VersionGroupDetail> VersionGroupDetails { get; }
        MoveDescription Move { get; }

    }
}
