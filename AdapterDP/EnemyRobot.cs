using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    public class EnemyRobot
    {
        Random myRand = new Random();

        public void smashWithHands()
        {
            int damage = myRand.Next(10) + 1;
            Console.WriteLine($"Enemy Robot causes {damage} damage with it's hands.");
        }
        public void walkForward()
        {
            int movement = myRand.Next(5) + 1;
            Console.WriteLine($"Enemy Robot moves forward {movement} spaces.");
        }

        public void reactToHuman(String pDriver)
        {
            Console.WriteLine($"Enemy Robot tramps on {pDriver}.");
        }
    }
}
