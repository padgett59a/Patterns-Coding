using System;

namespace AbstractFactoryPattern
{
    public class UFOBossEnemyShipFactory : IEnemyShipFactory
    {
        public IESWeapon addWeapon()
        {
            return new UFOBossGun();
        }
        public IESEngine addEngine()
        {
            return new UFOBossEngine();
        }
        //UFO Boss Ships only
        //public IESMissile addMissile()
        //{
        //    return new UFOBossMissile();
        //}
    }
}
