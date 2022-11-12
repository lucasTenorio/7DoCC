namespace Challenge.Domain.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetAsync(string id);
    }
}
