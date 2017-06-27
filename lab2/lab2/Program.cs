using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //josh winchester 2017
            Console.WriteLine("Welcome to the Magical Even or Odd Machine(TM).");
            Console.WriteLine("What is your name?");
            string thename = Console.ReadLine();
            Console.WriteLine("Thanks, " + thename + ". Please enter a number between 1 and 100");
            int thenum = int.Parse(Console.ReadLine());
            while (thenum <= 0 || thenum >= 100){
                Console.WriteLine("I see you did not enter a positive integer between 1 and 100, please enter a valid number.");
                thenum = int.Parse(Console.ReadLine());
            }
            //so program welcomes, asks for name, and retrieves number to crunch. If number is outside of expected range the user will be prompted to reenter again+again.

            float evenorodd = thenum % 2;
            //if thenum is 12 evenorodd will be 0; if it is 13 it will be 1. 

            if (evenorodd != 0)
            {
                Console.WriteLine(thename + ",the number you entered was: " + thenum + " and odd.");

            }
            if (thenum >= 2 && thenum <= 25 && evenorodd == 0) {
                Console.WriteLine(thename + ",the number you entered is even and less than 25.");
            }
            if (thenum >= 26 && thenum <= 60 && evenorodd == 0)
            {
                Console.WriteLine(thename + ", the number you entered is even.");
            }
            if (thenum > 60 && evenorodd == 0)
            {
                Console.WriteLine(thename + ",the number you enter is even."); 
            }
            if (thenum > 60 && evenorodd != 0)
            {
                Console.WriteLine(thename + ",the number you entered is odd.");

                //running all the conditionals, meat and tatoes of the program
            }
            Console.WriteLine("Thank you for using the Magical Even or Odd Machine(TM). The program will now terminate.");
        }
    }
}
