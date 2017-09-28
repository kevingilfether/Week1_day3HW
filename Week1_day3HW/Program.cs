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
            //Console.WriteLine("Give me a number (whole or not!):");
            //double num = double.Parse(Console.ReadLine());
            //if(num > 0)
            //{
            //    Console.WriteLine("This number is positive!");
            //}
            //else if(num < 0)
            //{
            //    Console.WriteLine("This number is negative!");
            //}
            //else
            //{
            //    Console.WriteLine("This number is a zero!");
            //}

            //#4 Checks letter for vowel or consonant.
            //Console.WriteLine("Give me a lowercase letter:");
            //char letter = char.Parse(Console.ReadLine());

            //if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //{
            //    Console.WriteLine("The letter " + "\"" + letter + "\"" + " is a vowel.");
            //}
            //else if (letter == 'y')
            //{
            //    Console.WriteLine("\"Y\" is a little funny.");
            //}
            //else
            //{
            //    Console.WriteLine("The letter \"" + letter + "\" is NOT a vowel.");
            //}

            //#5 Of two integers, picks the biggest and prints it

            //int firstNum;
            //int secondNum;

            //Console.WriteLine("Give me a number:");
            //firstNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("And another:");
            //secondNum = int.Parse(Console.ReadLine());

            //if (firstNum > secondNum)
            //{
            //    Console.WriteLine(firstNum + " is the largest number.");
            //}
            //else if (firstNum < secondNum)
            //{
            //    Console.WriteLine(secondNum + " is the largest number.");
            //}
            //else
            //{
            //    Console.WriteLine(firstNum + " and " + secondNum + " are the same!");
            //}


            //#5a - Same as 5, but 3 numbers.

            //int firstNum;
            //int secondNum;
            //int thirdNum;

            //Console.WriteLine("Give me a number:");
            //firstNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("And another:");
            //secondNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("And one more:");
            //thirdNum = int.Parse(Console.ReadLine());

            //if (firstNum > secondNum)
            //{
            //    if (firstNum > thirdNum)
            //    {
            //        Console.WriteLine(firstNum + " is the largest number.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(thirdNum + " is the largest number.");
            //    }
            //}
            //else if (firstNum < secondNum)
            //{
            //    if (secondNum > thirdNum)
            //    {
            //        Console.WriteLine(secondNum + " is the largest number.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(thirdNum + " is the largest number.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("At least two of those are the same!");
            //}

            //#6 Last for the night, calculates the mean of 4 integers!

            int firstNum;
            int secondNum;
            int thirdNum;
            int fourthNum;

            Console.WriteLine("Give me a whole number:");
            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another:");
            secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("A third:");
            thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine("A fourth:");
            fourthNum = int.Parse(Console.ReadLine());

            double total = firstNum + secondNum + thirdNum + fourthNum;
            double mean = total / 4;
            Console.WriteLine("The mean is " + mean);


        }
    }
}
