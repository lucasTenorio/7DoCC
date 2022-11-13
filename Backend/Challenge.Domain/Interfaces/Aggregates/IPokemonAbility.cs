using Challenge.Domain.Aggregates;

namespace Challenge.Domain.Interfaces.Aggregates
{
    public interface IPokemonAbility
    {
        Ability Ability { get; }
        bool IsHidden { get; }
        int slot { get; }
    }
}
