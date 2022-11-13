using Challenge.Domain.Interfaces.Aggregates;

namespace Challenge.Domain.Aggregates
{
    public class Types : ITypes
    {
        public int slot { get; set; }

        public Type Type { get; set; }
    }
}
