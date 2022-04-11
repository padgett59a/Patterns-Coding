using System;

namespace Factory_Coding
{
    //Abstract Class
    //public abstract class EnemyShip  //Works either way, since no abstract methods
    //public class EnemyShip  //Works either way, since no abstract methods
    public abstract class EnemyShip
    {
        protected string name { get; set; }
        //public string name;
        public double amtDamage { get; set; }
        public double Speed { get; set; }

        public void followHeroShip()
        {
            Console.WriteLine(name + " is following the hero");
        }
        public void enemyShipShoots()
        {
            Console.WriteLine(name + " is now fires and does " + amtDamage + "in damage.");
        }
        public void displayEnemyShip()
        {
            Console.WriteLine(name + " is now displayed");
        }

        //public abstract void mustDoThis();  //subclasses must implement
    }

}