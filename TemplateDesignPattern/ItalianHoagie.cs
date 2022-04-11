using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    class ItalianHoagie : absHoagie
    {
        String[] meats = new String[]{ "Salami", "Pepperoni", "Capicola Ham" };
        String[] cheeses = new String[] { "Swiss", "Provolone"};
        String[] veggies = new String[] { "Lettuce", "Tomatoes", "Onions" };
        String[] condiments = new String[] { "Mustard", "Mayo", "Italian Dressing" };


        public override void addCheese()
        {
            cheeses.ToList().ForEach(c => Console.WriteLine($"Adding {c}"));
        }

        public override void addCondiments()
        {
            condiments.ToList().ForEach(c => Console.WriteLine($"Adding {c}"));
        }

        public override void addMeat()
        {
            meats.ToList().ForEach(m => Console.WriteLine($"Adding {m}"));
        }

        public override void addVeggies()
        {
            veggies.ToList().ForEach(v => Console.WriteLine($"Adding {v}"));
        }

    }
}
