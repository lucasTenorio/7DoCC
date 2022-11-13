using Challenge.Domain.Aggregates;

namespace Challenge.Domain.Interfaces
{
    public interface IAbilities
    {
        Ability Ability { get; }
        bool is_hidden { get; }
        int slot { get; }
    }
}
