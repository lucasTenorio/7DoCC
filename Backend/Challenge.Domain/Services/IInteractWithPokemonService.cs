namespace Challenge.Domain.Services
{
    public interface IInteractWithPokemonService : IFluentSetPokemonId<IInteractWithPokemonService>, IFluentAnimalStatus<IInteractWithPokemonService>
    {
        Task<IAnimalStatus> CheckPokemonStatus();
        Task<IAnimalStatus> FeedPokemon();
        Task<IAnimalStatus> PlayWithPokemon();
        Task<IAnimalStatus> PutToRest();
    }
}
