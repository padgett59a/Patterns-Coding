using System;

namespace AbstractFactoryPattern
{
    public class UFOBossGun : IESWeapon
    {
        public String toString()
        {
            String retVal = null;
            retVal = "40 units";
            return retVal;
        }
    }
}
