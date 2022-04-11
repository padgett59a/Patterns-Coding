using System;

namespace AbstractFactoryPattern
{
    public abstract class aEnemyShip
    {
        public string name { get; set; }
        private double amtDamage;

        protected IESEngine engine;  //Socket for engine plug-in
        protected IESWeapon weapon;  //Socket for weapon plug-in
        //protected IESMissile missile;  //optional
        protected IMissiles hasMissiles;  //optional  object to see if we have missiles

        public abstract void decorateShip();  //require method for decoration with weapon, engine, etc
        public abstract void notifyShipGotMade();
        
        public void followHeroShip() {
            Console.WriteLine(name + " is following the hero");
        }
        public void enemyShipShoots()
        {
            Console.WriteLine(name + " is now fires and does " + weapon.toString() + " in damage.");
        }
        public void displayEnemyShip() {
            Console.WriteLine(name + " is now displayed");
        }

        public String toString()
        {
            String shipInfo = $"The {name} has a top speed of {engine} and an attack power of {weapon}.";
            return shipInfo;
        }

        public bool missileTest()
        {
            bool canShootMissiles = false;
            string missileString;
            if (hasMissiles != null)  //default - no missiles
            {
                canShootMissiles = hasMissiles.HasMissilesTest();
                missileString = canShootMissiles ? "I have missiles" : "I do not have missiles";
            }
            else
            {
                missileString = "I do not have missiles";
            }
            Console.WriteLine(missileString);
            return canShootMissiles;
        }
        //optional
        public void changeMissileCapability(IMissiles pMissileType)
        {
            hasMissiles = pMissileType;
        }
    }
}