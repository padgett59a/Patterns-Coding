using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKPDecorator
{
    internal class Pepperoni : AddToBase, IPizza
    {
        public Pepperoni(IPizza pPizza) : base(pPizza)
        {
            Console.WriteLine("Adding Pepperonis.");
        }
        string IPizza.getDescription()
        {
            return basePizza.getDescription() + "and Pepperoni ";
        }

        decimal IPizza.getTotalPrice()
        {
            return basePizza.getTotalPrice() + 1.85m;
        }
    }
}
