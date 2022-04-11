using System;

namespace Factory_Coding
{
    //Factory: create objects without knowning the exact class of object that will be created until runtime
    // hides creation logic from the calling code
    // - centralizes object creation code
    // - for runtime flexibility
    // - to add new types, extend the Factory ONLY
    //
    //eliminates var myWidget = new Widget();  <-- not extensible
    // instead var myWidget = WidgetFactory.Create(<T> objParam);  <== e.g. WidgetFactory.Create("widget1")
    // [WidgetFactory can be a static class]
    // use for creating a number of types of business objects



    public class EnemyShipTesting
    {
        public static void Main(string[] vars)
        {
            EnemyShipFactory enemyShipFactory = new EnemyShipFactory();
            EnemyShip theEnemy = null;

            char typeShip = '?';
            
            //Run time object flexibility
            while (typeShip != 'R' && typeShip != 'U')
            {
                if (typeShip != '?') { Console.Write("\nInvalid ship type, please try again."); }
                Console.Write("\nWhat kind if enemy ship you want? (U | R | B)?");
                typeShip = Console.ReadLine()[0];
            }
            
            //Get the runtime object from the ship Factory
            theEnemy = enemyShipFactory.makeEnemyShip(typeShip); //note: returns superclass (abstract) type
            if (theEnemy != null) { doStuffEnemy(theEnemy); }
            else { Console.WriteLine("There was a problem creating the enemy ship of type {0}.", typeShip); }
        } 

        public static void doStuffEnemy(EnemyShip enemyShip)
        {
            enemyShip.displayEnemyShip();
            enemyShip.followHeroShip();
            enemyShip.enemyShipShoots();
        }
    }
}
