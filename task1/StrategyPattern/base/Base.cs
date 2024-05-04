using task1.StrategyPattern.Enums;

namespace task1.StrategyPattern
{
     public abstract class Base
    {
        public abstract int Excute(int x, int y);
        public abstract Types Types { get; set; }
    }
}

