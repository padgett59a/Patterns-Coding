using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //Strategy Pattern
    public class CanShootMissle : IMissiles
    {
        public Boolean HasMissilesTest()
        {
            //Console.WriteLine("I can shoot a missile.");
            return true;
        }
    }
    public class NoCanShootMissle : IMissiles
    {
        public Boolean HasMissilesTest()
        {
            //Console.WriteLine("I can not shoot a missile.");
            return false;
        }
    }
}
