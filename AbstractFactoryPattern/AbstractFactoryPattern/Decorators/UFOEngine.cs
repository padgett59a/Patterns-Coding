using System;

namespace AbstractFactoryPattern
{
    //Create families of related objects without a concrete class
    //Run time flexibility across many objects 
    //Complex!
    public class UFOEngine : IESEngine
    {
        public String toString()
        {
            String retVal = null;
            retVal = "100 mph";
            return retVal;
        }
    }
}
