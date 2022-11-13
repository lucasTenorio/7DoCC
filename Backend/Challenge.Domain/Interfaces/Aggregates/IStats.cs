using Challenge.Domain.Aggregates;

namespace Challenge.Domain.Interfaces.Aggregates
{
    public interface IStats
    {
        int BaseStat { get; }
        int Effort { get; }
        Stat Stat { get; }
    }
}
