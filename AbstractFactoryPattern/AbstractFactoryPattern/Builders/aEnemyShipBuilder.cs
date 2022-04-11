namespace AbstractFactoryPattern
{
    public abstract class AbsEnemyShipBuilder
    {
        //Ordering mechanism for abstract aEnemyShip 
        protected abstract aEnemyShip makeEnemyShip(string shipType);

        
        //concrete method in this abstract class 
        //this is like the template pattern
        //a list of methods needed to build and decorate the ship
        public aEnemyShip orderTheShip(string shipType)  
        {           
            //call to subclassed builder method with pararm for right choosing factory
            aEnemyShip retShip = makeEnemyShip(shipType); 

            retShip.decorateShip();  //call to concrete class method
            retShip.displayEnemyShip();
            retShip.followHeroShip();
            retShip.enemyShipShoots();
            return retShip;
        }
    }
}