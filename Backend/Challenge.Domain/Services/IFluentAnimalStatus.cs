namespace Challenge.Domain.Services
{
    public interface IFluentAnimalStatus<T>
    {
        T Set(IAnimalStatus animalStatus);
    }
}