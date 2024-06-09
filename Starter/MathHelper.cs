using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 A static class is a class that cannot be instantiated and can only contain static members. 
Static classes are useful for grouping related utility or helper methods that do not require any object state.

Purpose: Used for utility or helper methods that don't need an instance of a class.
Characteristics: Cannot be instantiated; all members must be static.
Use Case: Grouping related static methods together.

 */
namespace Starter
{
    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Denominator cannot be zero.");
            return a / b;
        }
    }
}
