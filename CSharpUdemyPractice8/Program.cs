using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemyPractice8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            //numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program 
            //should display 8.

            char[] splitChar = { ',' };

            Console.WriteLine("Please enter a list of numbers separated by commas:  ");
            string text = Console.ReadLine();

            Console.WriteLine();//blank

            Console.WriteLine("You entered " + text + ".");

            Console.WriteLine();//blank
            
            var numbers= text.Split(splitChar); //creates an array with the numbers

            var maxValue = numbers.Max();

            Console.WriteLine("The highest value is " + maxValue);
        }
    }
}
