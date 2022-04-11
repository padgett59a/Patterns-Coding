using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Bird : Animal
    {
        public Bird()
        {
            this.flyingType = new CanFly();  //set flying type via ctor()
            Sound = "tweet";
        }

    }
}
