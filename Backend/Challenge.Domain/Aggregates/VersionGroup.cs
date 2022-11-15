using Challenge.Domain.Interfaces.Aggregates;

namespace Challenge.Domain.Aggregates
{
    public class VersionGroup : IVersionGroup
    {
        public string? Name { get; set; }

        public string? Url { get; set; }
    }
}
