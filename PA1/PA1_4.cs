/* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    DIRECTIONS:
    Modify the "doStuff" function.
    
    Write a program that will take user input for degrees in Celsius and convert it to Fahrenheit.
    The formula to convert Celsius to Fahrenheit is: F = (C * 1.8) + 32
    Where F is the temperature in Fahrenheit and C is the temperature in Celsius.

    Example:
    Input: 0
    Output: 32

    You will need to declare a variable to store the user input, and a variable to store the result of the conversion.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */


using System;

namespace PA1_4
{
    public class Problem
    {
        public void doStuff( )
        {
            // Do your work below
    Console.WriteLine ("Converting Celsius to Fehrenheit");
     float C = Convert.ToSingle(Console.ReadLine());
     float F = (C * 1.8f) + 32;
     Console.WriteLine($"input:  {C} ");
     Console.WriteLine($"Output: {F} ");
        }
    }
}
