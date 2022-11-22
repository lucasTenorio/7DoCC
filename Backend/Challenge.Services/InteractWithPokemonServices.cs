using Challenge.Domain.Entities;
using Challenge.Domain.Exceptions;
using Challenge.Domain.Services;

namespace Challenge.Services
{
    public class InteractWithPokemonServices : IInteractWithPokemonService
    {
        private int _id;
        private IAnimalStatus _animalStatus;
        public Task<IAnimalStatus> CheckPokemonStatus()
        {
            return Task.FromResult(GenerateRandomStatusForPokemon());
        }

        private IAnimalStatus GenerateRandomStatusForPokemon()
        {
            var random = new Random();
            var status = new AnimalStatus(random.Next(10), random.Next(10), random.Next(10));

            return status;
        }

        public async Task<IAnimalStatus> FeedPokemon()
        {
            if (_animalStatus == null) throw new ArgumentException(nameof(_animalStatus));

            if (_animalStatus.Fome >= 10) throw new AnimalNotHungryException();

            return await Task.FromResult(FeedAnimal());
            
        }

        private IAnimalStatus FeedAnimal()
        {
            _animalStatus.Fome += 2;
            _animalStatus.Energia -= 1;
            _animalStatus.Humor += 1;

            return _animalStatus;
        }

        public async Task<IAnimalStatus> PlayWithPokemon()
        {
            if (_animalStatus == null) throw new ArgumentException(nameof(_animalStatus));

            if (_animalStatus.Humor >= 10) throw new AnimalDoesntWannaPlayException();

            return await Task.FromResult(PlayWithAnimal());
        }

        private IAnimalStatus PlayWithAnimal()
        {
            _animalStatus.Fome -= 2;
            _animalStatus.Energia -= 1;
            _animalStatus.Humor += 2;

            return _animalStatus;
        }

        public async Task<IAnimalStatus> PutToRest()
        {
            if(_animalStatus == null) throw new ArgumentException(nameof(_animalStatus));

            if (_animalStatus.Energia >= 10) throw new AnimalDoesntWantToRestException();

            return await Task.FromResult(Rest());
        }

        private IAnimalStatus Rest()
        {
            _animalStatus.Fome -= 2;
            _animalStatus.Energia += 3;
            _animalStatus.Humor -= 2;

            return _animalStatus;
        }

        public IInteractWithPokemonService Set(int id)
        {
            _id = id;
            return this;
        }

        public IInteractWithPokemonService Set(IAnimalStatus animalStatus)
        {
            this._animalStatus = animalStatus;
            return this;
        }
    }
}
