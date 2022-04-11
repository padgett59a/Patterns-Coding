using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKPDecorator
{
    internal class Mozzarella : AddToBase, IPizza
    {
        public Mozzarella(IPizza pPizza) : base (pPizza)
        {
            Console.WriteLine("Adding Mozzarella cheese.");
        }
        string IPizza.getDescription()
        {
            return basePizza.getDescription() + "and Mozzarella cheese ";
        }

        decimal IPizza.getTotalPrice()
        {
            return basePizza.getTotalPrice() +  1.35m;
        }
    }
}
