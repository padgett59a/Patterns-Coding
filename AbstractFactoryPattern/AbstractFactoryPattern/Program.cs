using System;

namespace AbstractFactoryPattern
{
    //implements Strategy Pattern (encapsulation)
    //everythings encapsulated 
    // - the method that requests the object creation
    // - the factories that build individual object types
    // - the final objects (they use Strategy Pattern)
    //  -- Object class fields are objects
    //composition: object fields are objects
    //Allows families of related objects without specifying concrete classes
    //use when you have many objects that can be added or changed at runtime
    //objects interact through common interfaces
    //can get complex
    class Program
    {
        static void Main(string[] args)
        {
            //which factory do you want to call?
            AbsEnemyShipBuilder ufoBuilder = new UFOEnemyShipBuilder();

            //order the ship makes it, decorates (completes it), displays it
            aEnemyShip theGrunt = ufoBuilder.orderTheShip("UFO");
            Console.WriteLine(theGrunt.name + "\n");
            theGrunt.missileTest();  

            aEnemyShip theBoss = ufoBuilder.orderTheShip("UFO BOSS");
            Console.WriteLine(theBoss.name + "\n");
            theBoss.missileTest(); //missiles are added by composition in the decorate() of the Boss via Strategy Pattern

        }
    }
}
