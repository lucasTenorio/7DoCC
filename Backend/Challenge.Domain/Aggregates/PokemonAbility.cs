using Challenge.Domain.Interfaces.Aggregates;

namespace Challenge.Domain.Aggregates
{
    public class PokemonAbility : IPokemonAbility
    {
        public Ability Ability { get; set; } = new Ability();

        public bool IsHidden {get; set;}

        public int slot {get; set;}
    }
}
