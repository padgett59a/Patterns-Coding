using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Dog : Animal
    {
        public Dog()
        {
            this.flyingType = new CantFly();  //this will get updated at runtime
            Sound = "bark";
        }

    }
}
