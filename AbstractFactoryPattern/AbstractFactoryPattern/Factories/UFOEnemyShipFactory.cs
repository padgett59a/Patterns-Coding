using System;

namespace AbstractFactoryPattern
{
    public class UFOEnemyShipFactory : IEnemyShipFactory
    {
        public IESWeapon addWeapon()
        {
            return new UFOGun();
        }
        public IESEngine addEngine()
        {
            return new UFOEngine();
        }
    }
}
