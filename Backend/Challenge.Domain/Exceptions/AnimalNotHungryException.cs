namespace Challenge.Domain.Exceptions
{
    public class AnimalNotHungryException : Exception
    {
        public AnimalNotHungryException() : base("Animal not hungry!") 
        {

        }
    }
}
