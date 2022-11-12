using Challenge.Domain.Interfaces.Aggregates;

namespace Challenge.Domain.Aggregates
{
    public class PokeShortDescription : IPokeShortDescription
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public PokeShortDescription(string name, string url)
        {
            Name = name; 
            Url = url;
        }
    }
}
