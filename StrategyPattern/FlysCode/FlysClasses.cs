using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CanFly : IFlys
    {
        public String fly()
        {
            return $"I can fly.";
        }
    }
    public class CantFly : IFlys
    {
        public String fly()
        {
            return $"I can't fly.";
        }
    }
    public class FastFlyer : IFlys
    {
        public String fly()
        {
            return $"I can fly fast.";
        }
    }
    public class SlowFlyer : IFlys
    {
        public String fly()
        {
            return $"I can fly but not too fast.";
        }
    }
}
