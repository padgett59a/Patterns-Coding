using System;
namespace Factory_Coding
{
    public class EnemyShipFactory
    {

        //Run time object creation
        public EnemyShip makeEnemyShip(char newShipType)
        {
            EnemyShip theEnemy = null;
            switch (newShipType)
            {
                case 'U':
                    {
                        theEnemy = new UFOEnemyShip();
                        break;
                    }
                case 'R':
                    {
                        theEnemy = new RocketEnemyShip();
                        break;
                    }

                case 'B':
                    {
                        theEnemy = new BigUFOEnemyShip();
                        break;
                    }
                default:
                    {
                        Console.Write("Invalid ship type passed!");
                        break;
                    }
            }

            return theEnemy;
        }
    }
}