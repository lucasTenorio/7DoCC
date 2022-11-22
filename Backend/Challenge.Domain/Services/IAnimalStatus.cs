namespace Challenge.Domain.Services
{
    public interface IAnimalStatus
    {
        int Fome { get; set; }
        int Humor { get; set; }
        int Energia { get; set; }
    }
}