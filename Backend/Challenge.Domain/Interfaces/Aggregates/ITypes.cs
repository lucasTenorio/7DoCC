using Challenge.Domain.Aggregates;

namespace Challenge.Domain.Interfaces.Aggregates
{
    public interface ITypes
    {
        int slot { get; }
        Domain.Aggregates.Type Type { get; }
    }
}
