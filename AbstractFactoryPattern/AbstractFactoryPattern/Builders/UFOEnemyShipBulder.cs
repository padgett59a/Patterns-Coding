using System;

namespace AbstractFactoryPattern
{
    public class UFOEnemyShipBuilder : AbsEnemyShipBuilder
    {
        //make a UFO ship and assign a factory to decorate it
        protected override aEnemyShip makeEnemyShip(String shipType) 
        {
            aEnemyShip retShip = null;

            switch (shipType)
            {
                case "UFO":
                    IEnemyShipFactory ufoFactory = new UFOEnemyShipFactory();
                    retShip = new UFOEnemyShip(ufoFactory);  //IoC: Ship decorates itself from passed factory
                    retShip.name = "UFO Grunt Ship";
                    break;
                case "UFO BOSS":
                    IEnemyShipFactory ufoBossFactory = new UFOBossEnemyShipFactory();
                    retShip = new UFOBossEnemyShip(ufoBossFactory); //IoC: Ship decorates itself from passed factory
                    retShip.name = "UFO Boss Ship" ;
                    break;
                default :
                    Console.WriteLine("You must select a valid Ship Type before proceeding.");
                    break;
            }
            return retShip;
        }
    }
}
