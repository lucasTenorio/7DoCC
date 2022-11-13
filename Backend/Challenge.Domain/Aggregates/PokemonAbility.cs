using Challenge.Domain.Interfaces.Aggregates;

namespace Challenge.Domain.Aggregates
{
    public class PokemonAbility : IPokemonAbility
    {
        public Ability Ability {get; set;}

        public bool IsHidden {get; set;}

        public int slot {get; set;}
    }
}
