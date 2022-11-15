using Challenge.Domain.Interfaces;

namespace Challenge.Domain.Aggregates
{
    public class Abilities : IAbilities
    {
        public Ability Ability { get; set; } = new Ability();

        public bool is_hidden {get;set;}

        public int slot {get;set;}
    }
}
