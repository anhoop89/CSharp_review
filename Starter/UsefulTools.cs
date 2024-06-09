using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  
Static Methods in a Class

Purpose: Used for methods that belong to a class but don't operate on instance data.
Characteristics: Can be called on the class itself; cannot access instance variables directly.
Use Case: Factory methods, singleton pattern, or general utility methods within a class.

 */
namespace Starter
{
    internal class UsefulTools
    {
        public static void SayHi(string name) 
        {
            Console.WriteLine("Hello " + name );
        }

    }
}
