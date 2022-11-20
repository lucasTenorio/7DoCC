using Challenge.Domain.Interfaces.Aggregates;
using System.Text.RegularExpressions;

namespace Challenge.Domain.Aggregates
{
    public class PokeShortDescription : IPokeShortDescription
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public int PokemonId { get; set; }

        public PokeShortDescription(string name, string url)
        {
            Name = name; 
            Url = url;
            PokemonId = GetIdFromUrl();
        }
        private int GetIdFromUrl()
        {
            var regex = Regex.Match( Url, "(?<=^([^/]*/){"+(Url.Count(ch => ch.Equals('/')) - 1)+"})([^/]*)").Value;
            Int16.TryParse(regex, out short result);
            return result;
        }
    }
}
