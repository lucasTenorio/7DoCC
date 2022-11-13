using Challenge.Domain.Aggregates;


namespace Challenge.Domain.Interfaces.Aggregates
{
    public interface IGameIndice
    {
        int gameIndex { get; set; }
        Domain.Aggregates.Version Version { get; set; }
    }
}
