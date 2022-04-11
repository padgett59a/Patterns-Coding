using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Animal
    {
        protected string Name;
        public double Height;
        public int Weight;
        public string FavFood;
        public double Speed;
        public string Sound;

        //********* Changes to add Flying capability ****************//

        protected IFlys flyingType;  //optional flying capability class delegate placeholder

        //try to Fly
        public String tryToFly()
        {
            //  might add check for if flyingType != null
            return flyingType.fly();
        }

        //change flying ability at runtime
        public void makeFlyer(IFlys newFlyType)
        {
            this.flyingType = newFlyType;  //this is a class implementing the flys() method
        }

        //********* END Changes to add Flying capability ****************//

    }
}
