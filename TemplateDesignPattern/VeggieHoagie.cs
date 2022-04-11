using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    class VeggieHoagie : absHoagie
    {
        String[] veggies = new String[] { "Lettuce", "Tomatoes", "Onions" };
        String[] condiments = new String[] { "Mustard", "Mayo", "Italian Dressing" };


        public override void addCheese()
        {
            Console.WriteLine("Veggie Hoagie : no cheese");
        }

        public override void addCondiments()  //note: must override
        {
            condiments.ToList().ForEach(c => Console.WriteLine($"Adding {c}"));
        }

        public override void addMeat()
        {
            Console.WriteLine("Veggie Hoagie : no meat");
        }

        public override void addVeggies()
        {
            veggies.ToList().ForEach(v => Console.WriteLine($"Adding {v}"));
        }



        public override bool wantsCheese()
        {
            return false;
        }

        public override bool wantsMeat()
        {
            return false;
        }

    }
}
