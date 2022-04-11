using System;

namespace AKPDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza myPizza = new Pepperoni(new Mozzarella(new TomatoSauce(new BasicPizza())));

            Console.WriteLine($"Your Pizza order is: {myPizza.getDescription()}");
            Console.WriteLine($"Your final cost: {myPizza.getTotalPrice() }");
        }
    }
}
