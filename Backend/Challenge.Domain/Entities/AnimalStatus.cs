using Challenge.Domain.Services;

namespace Challenge.Domain.Entities
{
    public class AnimalStatus : IAnimalStatus
    {
        public int Fome { get; set; }
        public int Humor { get; set; }
        public int Energia { get; set; }

        public AnimalStatus(int fome, int humor, int energia)
        {
            Fome = fome;
            Humor = humor;
            Energia = energia;
        }
    }
}
