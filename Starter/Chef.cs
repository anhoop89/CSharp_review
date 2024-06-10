using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 this class is built for inheritance structure 
 */
namespace Starter
{
    abstract class Restaurant()
    {
        public abstract void Location();

        public void Event()
        {
            Console.WriteLine("ABSTRACT: Hosting an event from the abstract class of the restaurant ");
        }
    }
    // super class 
    internal class Chef: Restaurant
    {
        public Chef() {
            Console.WriteLine("\n\nConstructor for the main parent class - Chef class");
        }
        public void MakeChicken()
        {
            Console.WriteLine("Chef Make Chicken! \n");
        }

        public void MakeFish()
        {
            Console.WriteLine("Chef Make Fish! \n");
        }
        // abstract function method
        public override void Location()
        {
            Console.WriteLine(" Chef class: Location is overrided from the abstract class");
        }
        // virtual method
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq rids!\n");
        }
    }

    // sub-classes
    class VietnameseChef : Chef
    {
        public VietnameseChef()
        {
            Console.WriteLine("Contructor for the vietnamese chef class");
        }

        public void MakeVietDish()
        {

            Console.WriteLine("This Vietnamese Chef makes vietnamese dishes!\n");
        }
      
        public override void MakeSpecialDish()
        {
            base.MakeSpecialDish();
            Console.WriteLine("Vietnamese Chef can do Vietnamese Pho!\n");
        }
    }
}
