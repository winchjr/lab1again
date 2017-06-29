using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string keepgoing = "y";
            //now we have user input, and have determined whether it can derive factorials from it. Now we can go into the method here
            while (keepgoing == "y") {
                factorial();
                Console.WriteLine("Want to find another factorial? y/n ");
                keepgoing = Console.ReadLine();
            }
        }
        public static void factorial()
        {
            Console.WriteLine("Whats the number you want to find the factorial for (between 1-10 only please)?");
            string userInput = Console.ReadLine();
            long finalAnswer=0;
            long result;
            bool u = long.TryParse(userInput, out result);
            long originalInput = result;
            long answer = result;
            result = answer;

            //initializing variables and asking for user input
            if (u == true)
            {
                Console.WriteLine("The factorial you are searching for is " + result + "!");
            }

            //the for loop, calculations
            for (long cont = result; cont != 0; cont--){
              
              finalAnswer = answer; //finalanswer = 3 for user input of 3
              answer = (result - 1) * finalAnswer; //answer = 6; then answer will equal 6
                result--;
                if (cont == 1)
                {
                    Console.WriteLine("The factorial of " + originalInput + " is " + finalAnswer);
                    result = 1;
                    break;
                }
                //looks like this program can only go up to 20! accurately
             }
        }
    }
}
