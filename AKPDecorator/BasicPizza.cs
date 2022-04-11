using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKPDecorator 
{
    class BasicPizza : IPizza
    {
        public BasicPizza()
        {
            Console.WriteLine($"Starting with a Basic Pizza.");
        }
        string IPizza.getDescription()
        {
            return "Basic Pizza ";
        }

        decimal IPizza.getTotalPrice()
        {
            return 6.5m;
        }
    }
}
