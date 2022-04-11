using System;

namespace AdapterDP
{
    //allows 2 incomaptible interfaces to work together
    //converts available interface to the target interface
    class Program
    {
        static void Main(string[] args)
        {
            EnemyTank myBadTank = new EnemyTank();
            EnemyRobot myBadBot = new EnemyRobot();

            //Create adapter and decorate it with a robot
            //IEnemyAttacker myBadAdapterMan = new EnemyRobotAdapter(myBadBot);
            IEnemyAttacker myBadAdapterMan = new EnemyRobotAdapter(new EnemyRobot());

            //Console.WriteLine($"\n{myBadBot.GetType().Name}");
            //myBadBot.reactToHuman("Paul");
            //myBadBot.walkForward();
            //myBadBot.smashWithHands();

            Console.WriteLine($"\n{myBadTank.GetType().Name}");
            myBadTank.assignDriver("Frank");
            myBadTank.fireWeapon();
            myBadTank.driveFoward();

            //Adapter object makes normal calls as Enemy Attacker type, but it results in Robot method calls
            Console.WriteLine($"\n{myBadAdapterMan.GetType().Name}");
            //Adapter makes an Enemy Attacker that is adapted to the Robot interface
            myBadAdapterMan.fireWeapon();
            myBadAdapterMan.driveFoward();
            myBadAdapterMan.assignDriver("Josie");

        }
    }
}
