using System;

namespace AbstractFactoryPattern
{
    public class UFOBossEnemyShip : aEnemyShip
    {


        IEnemyShipFactory shipFactory;
        public UFOBossEnemyShip(IEnemyShipFactory pShipFactory)
        {
            this.shipFactory = pShipFactory;
        }

        public override void notifyShipGotMade()
        {
            Console.WriteLine("{0} has been created.", name);
        }

        public override void decorateShip()
        {
            Console.WriteLine("\n\ndecorating enemy ship of type: {0}", name);
            Console.WriteLine("Adding Weapon to {0}", name);
            //has a weapon via abstract type - composition, Strategy
            weapon = shipFactory.addWeapon();

            Console.WriteLine("Adding engine to {0}", name);
            engine = shipFactory.addEngine();

            Console.WriteLine("Adding missile capability to {0}", name);
            hasMissiles = new CanShootMissle();

        }

    }
}