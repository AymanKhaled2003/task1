using task1.StrategyPattern.Enums;

namespace task1.StrategyPattern
{
    public class StrategyImp : IStrategy
    {
        private readonly IEnumerable<Base> _strategy;
        public StrategyImp(IEnumerable<Base> strategy)
        {
            _strategy =strategy;   
        }
        public Base CreateCase(Types Types)
        {
            var type=_strategy.FirstOrDefault(x=>x.Types== Types);
            return type;
        }
    }
}
