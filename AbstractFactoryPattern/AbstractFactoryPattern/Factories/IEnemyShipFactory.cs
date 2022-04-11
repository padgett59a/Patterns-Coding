using System;

namespace AbstractFactoryPattern
{
    public interface IEnemyShipFactory
    {
        public IESWeapon addWeapon();
        public IESEngine addEngine();
    }
}