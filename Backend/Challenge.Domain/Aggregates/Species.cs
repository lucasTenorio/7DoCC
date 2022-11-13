using Challenge.Domain.Interfaces.ValueObject;

namespace Challenge.Domain.Aggregates
{
    public class Species : IDescriptionUrl
    {
        public string Name { get; set; }

        public string Url { get; set; }
    }
}
