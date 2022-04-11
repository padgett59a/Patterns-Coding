using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public abstract class absHoagie
    {
        public virtual bool wantsMeat() { return true; } //default - "hook" optoinal override 
        public virtual bool wantsCheese() { return true; } //default - "hook" optoinal override 
        public virtual bool wantsVeggies() { return true; }
        public virtual bool wantsCondiments() { return true; }

        public void makeSandwich()
        {
            //call list of methods, some abastract, some concrete, some optional
            cutBun();
            if (wantsMeat()) { addMeat(); }
            if (wantsCheese()) { addCheese(); }
            if (wantsVeggies()) { addVeggies(); }
            if (wantsCondiments()) { addCondiments(); }
            wrapHoagie();
        }
        public void cutBun()
        {
            Console.WriteLine($"Cutting the bun.");
        }
        public abstract void addMeat();
        public abstract void addCheese();
        public abstract void addVeggies();
        public abstract void addCondiments();
        public void wrapHoagie()
        {
            Console.WriteLine($"Wrapping finished sandwich.");
        }
}
}
