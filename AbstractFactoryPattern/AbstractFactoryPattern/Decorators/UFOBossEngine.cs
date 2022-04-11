using System;

namespace AbstractFactoryPattern
{
    public class UFOBossEngine : IESEngine
    {
        public String toString()
        {
            String retVal = null;
            retVal = "2000 mph";
            return retVal;
        }
    }
}
