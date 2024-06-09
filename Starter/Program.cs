using Starter;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    
    static void Main(string[] args)
    {
        // hello world
        SayHi("Anh Ho");
        // Review switch case statement 
        Console.WriteLine("Today is " + GetDate(2));
        // print 2 dimensional array
        TwoDimesionalArr();
        // DivisionNumber
        // DivisionNumber();

        //using classes and object
        BookClass book1 = new BookClass();
        Console.WriteLine(book1.author + book1.title + book1.pages);


        // end line
        Console.WriteLine("\n\n\n -- Enter to Quit! -- \n");
        Console.ReadLine();
    }

    static void SayHi (string name)
    {
        Console.WriteLine("This is Say Hi to " + name);
    }

    static string GetDate(int input)
    {
        switch (input)
        {
            case 0: return "Sunday";
            case 1: return "Monday";
            case 2: return "Tuesday";
            case 3: return "Wednesday";
            case 4: return "Thursday";
            case 5: return "Friday";
            case 6: return "Saturday";
            default: return "Invalid input";
        }
    }


    static void TwoDimesionalArr()
    {
        // [row,col]
        int[,] numberGrid =
        {
            {1,2},
            {3,4},
            {5,6},
        };

        /*      
                GetLength(0): Returns the number of rows in the array.
                GetLength(1): Returns the number of columns in the array.
        */

        for (int i = 0; i < numberGrid.GetLength(0); i++)
        {
            for (int j = 0; j < numberGrid.GetLength(1); j++)
            {
                Console.WriteLine(numberGrid[i, j]);
            }
        }
    }

    static void DivisionNumber()
    {

        try
        {
            Console.Write("Enter 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);
        }
        catch (Exception e)
        { 
            // display the err message please they put a wrong input

            Console.WriteLine(e.Message);
        }
        finally 
        {
            Console.WriteLine("-- End Calculation!!! --"); 
        }
    }
 }
