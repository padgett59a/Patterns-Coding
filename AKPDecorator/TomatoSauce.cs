using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKPDecorator
{
    internal class TomatoSauce : AddToBase, IPizza
    {
        public TomatoSauce(IPizza pPizza) : base(pPizza)
        {
            Console.WriteLine("Adding TomatoSauce cheess.");
        }
        string IPizza.getDescription()
        {
            return basePizza.getDescription() + "and Tomato Sauce ";
        }

        decimal IPizza.getTotalPrice()
        {
            return basePizza.getTotalPrice() + .65m;
        }
    }
}
