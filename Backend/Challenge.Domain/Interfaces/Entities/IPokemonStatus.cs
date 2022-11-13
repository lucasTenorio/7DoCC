using Challenge.Domain.Aggregates;
using Challenge.Domain.Interfaces.ValueObject;

namespace Challenge.Domain.Interfaces.Entities
{
    public interface IPokemonStatus
    {
        int Id { get; }
        bool IsDefault { get; }
        string LocationAreaEncounters { get; }
        string Name { get; }
        int Order { get; }
        float Height { get; }
        float Weight { get; }
        int BaseExperience { get; }
        List<PokemonMove> Moves { get; }
        List<Stats> Stats { get; }
        List<Types> Types { get; }
        List<Abilities> Abilities { get; }  
        List<Form> Forms { get; }
        List<GameIndice> GameIndices { get; }
        Species Species { get; }



    }
}
