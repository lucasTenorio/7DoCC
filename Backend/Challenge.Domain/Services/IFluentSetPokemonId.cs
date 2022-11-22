namespace Challenge.Domain.Services
{
    public interface IFluentSetPokemonId<T>
    {
        T Set(int id);
    }
}