using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Sheep : IAnimal
    {
        public string woolColor { get; set; }

        public Sheep(string furColor)
        {
            this.woolColor = furColor;
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IAnimal makeShallowCopy()  //IAnimal because it is being called by generic AnimalCloneFactory
        {
            Console.WriteLine("Sheep is being made.");

            Sheep objSheep = null;
            try
            {
                //clone base object and cast it as a sheep subclass type 
                //Creates a shallow copy
                //Changing reference type values (string, obj) for either current or new WILL affect the other object
                
                //Make a new animal and cast it as a sheep
                //objSheep = (Sheep)base.MemberwiseClone();
                objSheep = (Sheep)this.MemberwiseClone();  //avoids expensive "new ()"

                //Note to make this a deep copy, add code to create new reference types with existing values
                //e.g., objSheep.refType = new RefType(this.refType.value1, this.refType.value2) etc
                //OR objSheep.refType = this.refType.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace.ToString());
            }

            return objSheep;
        }
        public IAnimal makeDeepCopy()
        {
            Console.WriteLine("Sheep is being made.");

            Sheep objSheep = null;
            try
            {
                //clone base object and cast it as a sheep subclass type 
                //Creates a shallow copy
                //Changing reference type values (string, obj) for either current or new WILL affect the other object
                //Make a new animal and cast it as a sheep
                objSheep = (Sheep)base.MemberwiseClone();
                //Note to make this a deep copy, add code to create new reference types with existing values
                //e.g., objSheep.refType = new RefType(this.refType.value1, this.refType.value2) etc
                //OR objSheep.refType = this.refType.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace.ToString());
            }

            return objSheep;
        }

        public override string ToString()
        {
            return @"Sheep says 'Baaaa'";
        }
    }
}
