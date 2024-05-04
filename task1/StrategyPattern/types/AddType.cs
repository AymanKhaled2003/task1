using task1.StrategyPattern.Enums;

namespace task1.StrategyPattern.types
{
    public class AddType : Base
    {
        public override Types Types { get ; set ; }= Types.Add; 

        public override int Excute(int x, int y)
        {
           return x + y;
        }
    }
}
