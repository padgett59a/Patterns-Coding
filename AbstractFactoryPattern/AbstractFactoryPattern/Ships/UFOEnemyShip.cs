using System;

namespace AbstractFactoryPattern
{
    public class UFOEnemyShip : aEnemyShip
    {
        
        
        private IEnemyShipFactory shipFactory;
        public UFOEnemyShip(IEnemyShipFactory pShipFactory)
        {
            //This factory is used to decorate the newly made Enemy Ship
            this.shipFactory = pShipFactory;
        }

        public override void notifyShipGotMade()
        {
            Console.WriteLine("{0} has been created.", name); 
        }
        public override void decorateShip()
        {
            Console.WriteLine("making enemy ship of type: {0}", name);
            weapon = shipFactory.addWeapon(); //object per Strategy Pattern
            engine = shipFactory.addEngine(); //object per Strategy Pattern
            this.notifyShipGotMade();
        }

    }
}