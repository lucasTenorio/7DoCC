using Challenge.Domain.Aggregates;
using Challenge.Domain.Interfaces.Aggregates;

namespace Challenge.Domain.Interfaces.Entities
{
    public interface IApiResult
    {
        public int Count { get; }
        public string Next { get; }
        public string Previous { get; }
        public List<PokeShortDescription> Results { get; }
    }
}
