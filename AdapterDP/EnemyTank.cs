using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdapterDP
{
    public class EnemyTank : IEnemyAttacker
    {
        Random myRand = new Random();
        private string thisDriver;
        
        public void assignDriver(String pDriver)
        {
            this.thisDriver = pDriver;
            Console.WriteLine($"Attack driver {thisDriver} is at the helm.");
        }

        public void driveFoward()
        {
            int movement= myRand.Next(5) + 1;
            Console.WriteLine($"Enemy moves {movement} spaces forward.");
        }

        public void fireWeapon()
        {
            int damage = myRand.Next(10) + 1;
            Console.WriteLine($"Enemy does {damage} damage.");
        }
    }
}
