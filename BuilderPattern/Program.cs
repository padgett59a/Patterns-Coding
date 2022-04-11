using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //RETRO
            //instantiate concrete builder of desired type
            IRobotBuilder retroRobotBuilder = new RetroRobotBuilder();

            //Pass builder to the director (the blueprint for building)
            RobotDirector myDirector = new RobotDirector(retroRobotBuilder);
            
            myDirector.makeRobot();  //Directory calls Builder methods to create Robot
            Robot myRetroRobot = myDirector.getRobot(); //Get it from the Director

            Console.WriteLine($"Retro robot's head is {myRetroRobot.robotHead}.");

            //MINI
            //instantiate concrete builder of desired type
            IRobotBuilder miniRobotBuilder = new MiniRobotBuilder();

            //Pass builder to the director (the blueprint for building)
            RobotDirector myMiniDirector = new RobotDirector(miniRobotBuilder);

            myMiniDirector.makeRobot();  //Directory calls Builder methods to create Robot
            Robot myMiniRobot = myMiniDirector.getRobot(); //Get it from the Director 

            Console.WriteLine($"Mini robot's head is {myMiniRobot.robotHead}.");


        }
    }
}
