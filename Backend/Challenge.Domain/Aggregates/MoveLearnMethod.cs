using Challenge.Domain.Interfaces.Aggregates;

namespace Challenge.Domain.Aggregates
{
    public class MoveLearnMethod : IMoveLearnMethod
    {
        public string Name { get; set; }

        public string Url { get; set; }
    }
}
