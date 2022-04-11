using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    //Makes a tank work like a robot by adapting the interfaces
    public class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot myRobot;

        public EnemyRobotAdapter(EnemyRobot pRobot)
        {
            myRobot = pRobot;
        }

        public void assignDriver(string pDriver)
        {
            myRobot.reactToHuman(pDriver);
        }

        public void driveFoward()
        {
            myRobot.walkForward();
        }

        public void fireWeapon()
        {
            myRobot.smashWithHands();
        }
    }
}
