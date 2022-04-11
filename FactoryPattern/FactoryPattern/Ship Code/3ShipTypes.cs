using System;

namespace Factory_Coding
{

    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            name = "RocketEnemyShip";
            amtDamage = 10.0;
        }

    }
    public class UFOEnemyShip : EnemyShip
    {
        public UFOEnemyShip()
        {
            name = "UFOEnemyShip";
            amtDamage = 20.0;
        }
    }
    public class BigUFOEnemyShip : UFOEnemyShip
    {
        public BigUFOEnemyShip() 
        {
            name = "Big UFO Enemy Ship";
            amtDamage = 50.0 ;
        }
    }
}