using System;

namespace TemplateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMaking Italian Hoagie");
            ItalianHoagie myItalianHoagie = new ItalianHoagie();
            myItalianHoagie.makeSandwich();

            Console.WriteLine("\nMaking Veggie Hoagie");
            VeggieHoagie myVeggieHoagie = new VeggieHoagie();
            myVeggieHoagie.makeSandwich();
        }
    }
}
