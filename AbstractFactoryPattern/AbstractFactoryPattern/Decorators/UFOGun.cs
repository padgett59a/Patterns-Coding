using System;

namespace AbstractFactoryPattern
{
    public class UFOGun : IESWeapon
    {
        public String toString()
        {
            String retVal = null;
            retVal = "20 units";
            return retVal;
        }
    }
}
