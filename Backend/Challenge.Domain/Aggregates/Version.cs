using Challenge.Domain.Interfaces.ValueObject;

namespace Challenge.Domain.Aggregates
{
    public class Version : IDescriptionUrl
    {
        public string? Name { get; set; }

        public string? Url {get; set;}   
    }
}
