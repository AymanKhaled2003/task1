using task1.StrategyPattern.Enums;

namespace task1.StrategyPattern.types
{
    public class MinusType : Base
    {
        public override Types Types { get; set; } = Types.Miuns;

        public override int Excute(int x, int y)
        {
            return x - y;
        }
    }
}
