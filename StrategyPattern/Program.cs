using System;
using System.Linq;

namespace StrategyPattern
{
    //Abstract classes should have only methods common to subclasses
    //A superclass (abstract class) change should not break code in a subclass and vice versa
    //Strategy gives ability to add optional capability at run time
    class Program
    {
        static void Main(string[] args)
        {
            Dog sparky = new Dog();
            Bird tweety = new Bird();

            Console.WriteLine("Sparky: " + sparky.tryToFly());
            Console.WriteLine("Teety: " + tweety.tryToFly());

            //Dynmically Add Flying ability to my dog at run time
            sparky.makeFlyer(new CanFly());
            Console.WriteLine("Sparky: " + sparky.tryToFly());

        }
    }
}
