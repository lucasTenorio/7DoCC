using Challenge.Domain.Interfaces.Aggregates;
using Challenge.Domain.Interfaces.ValueObject;

namespace Challenge.Domain.Aggregates
{
    public class MoveDescription : IDescriptionUrl
    {
        public string Name { get; set; }

        public string Url { get; set; }
    }
}
