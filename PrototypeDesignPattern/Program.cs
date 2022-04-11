using System;

namespace PrototypeDesignPattern
{
    //ProtoType DP
    //Create new instances by copying existing objects
    //Add subclass instance of known super class at run time
    //Use when there are many potential instnances of a class that you may need at run time
    //Reduces need for lots of subclass types being created through expensive object construction
    class Program
    {
        static void Main(string[] args)
        {
            AnimalCloneFactory animalMaker = new AnimalCloneFactory();
            Sheep mySheep = new Sheep("black");  //object to be cloned

            //New instance from existing instance
            Sheep clonedSheep = (Sheep)animalMaker.getClone(mySheep);  //results in .makeShallowCopy() call on passed sheep instance
            Console.WriteLine($"Cloned sheep color is {clonedSheep.woolColor}");

            //NOTE: need additional code for a deep copy

        }
    }
}
