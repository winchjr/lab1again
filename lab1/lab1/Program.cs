using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //joshua winchester 2017
            //program runs while the bool var calculation is true
            string calculation = "y";
            while (calculation == "y")
            {
                
                Console.WriteLine("Welcome to the Classroom area and perimeter calculator!");
                Console.WriteLine("Please enter your rooms' length first, press enter, the width, press enter, then heighth, press enter.");

                //welcoming
                Console.Write("Length:");
               double userLength = double.Parse(Console.ReadLine());
                Console.Write("Width:");
                double userWidth = double.Parse(Console.ReadLine());
                Console.Write("Heighth:");
                double userHeighth = double.Parse(Console.ReadLine());
                //user inputs userLength and userWidth and userHeighth

                double userArea = userWidth * userLength;
                double userPerimeter = (userWidth * 2) + (userLength * 2);
                double userVolume = (userWidth * userLength * userHeighth);
                //program creates variables and calculates the area and perimeter and volume

                Console.WriteLine("The area of this room is " + userArea);
                Console.WriteLine("The perimeter of this room is " + userPerimeter);
                Console.WriteLine("The volume of this room is " + userVolume);
                //program spits out perimeter and area and volume

                Console.WriteLine("Would you like to calculate another room? Please type y for yes; otherwise, hit n or any other key to end.");
                calculation = Console.ReadLine();
                //program asks for a continuation from the user; y will continue the while loop, n or any other input will end the program
      






            }
        }
    }
}
