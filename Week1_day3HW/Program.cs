using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day3HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditional Practice
            //#1 - checks if integers are equal
            //Console.WriteLine("I'm gonna do a trick. Give me a whole number:");
            //int firstNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("And another number:");
            //int secondNum = int.Parse(Console.ReadLine());
            //if (firstNum == secondNum) 
            //{
            //    Console.WriteLine("Wowee! Those numbers are equal. Isn't that neat?");
            //}
            //else
            //{
            //    Console.WriteLine("Those numbers aren't equal! I'm pretty spiffy, if I do say so myself.");
            //}


            //#2 Tells me if a number is even or odd
            //Console.WriteLine("Give me a whole number:");
            //int num = int.Parse(Console.ReadLine());
            //if(num % 2 == 0)
            //{
            //    Console.WriteLine(num + " is an even number.");
            //}
            //else
            //{
            //    Console.WriteLine(num + " is an odd number.");
            //}

            //#3 Writes whether a number is positive or negative
            Console.WriteLine("Give me a number (whole or not!):");
            double num = double.Parse(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("This number is positive!");
            }
            else if(num < 0)
            {
                Console.WriteLine("This number is negative!");
            }
            else
            {
                Console.WriteLine("This number is a zero!");
            }

            

        }
    }
}
