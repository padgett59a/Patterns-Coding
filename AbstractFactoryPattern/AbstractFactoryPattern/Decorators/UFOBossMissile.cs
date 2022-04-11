using System;

namespace AbstractFactoryPattern
{
    public class UFOBossMissile : IESMissile
    {
        public String toString()
        {
            string retVal = "Heat Seeker";
            return retVal;
        }
    }
}
