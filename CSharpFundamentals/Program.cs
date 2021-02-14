using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* 
             Write a program and ask the user to enter a number. The number
             should be between 1 to 10. If the user enters a valid number,
             display "Valid" on the console. Otherwise, display "Invalid".
            */
            Console.WriteLine("Please enter a number between 1 & 10: ");
            int input = Int32.Parse(Console.ReadLine());
            if (input <= 0 || input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            /*
             Write a program which takes two numbers from the console and
             displays the maximum of the two.
            */
            Console.WriteLine("Please enter a number: ");
            int input1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int input2 = Int32.Parse(Console.ReadLine());
            if (input1 < input2)
            {
                Console.WriteLine("{0} is larger.", input2);
            } else
            {
                Console.WriteLine("{0} is larger.", input1);
            };

            /*
             Write a program and ask the user to enter the width and height
             of an image. Then tell if the image is landscape or portrait.
            */
            Console.WriteLine("Please enter image height: ");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter image width: ");
            int width = Int32.Parse(Console.ReadLine());
            if(height > width)
            {
                Console.WriteLine("Your image is portrait dimensions.");
            } else
            {
                Console.WriteLine("Your image is landscape dimensions.");
            }
            /*
             Your job is to write a program for a speed camera. For simplicity,
             ignore the details such as camera, sensors, etc and focus purely
             on the logic. Write a program that asks the user to enter the
             speed limit. Once set, the program asks for the speed of a car.
             If the user enters a value less than the speed limit, program
             should display Ok on the console. If the value is above the speed
             limit, the program should calculate the number of demerit points.
             For every 5km/hr above the speed limit, 1 demerit points should be
             incurred and displayed on the console. If the number of demerit
             points is above 12, the program should display License Suspended.
             */
            Console.WriteLine("Please enter the speed limit: ");
            int speedLimit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your speed: ");
            int speed = Int32.Parse(Console.ReadLine());

            int difference = speed - speedLimit;

            if (difference >= 12)
            {
                Console.WriteLine("License Suspended");
            } else if (difference < 12 && difference > 5)
            {
                Console.WriteLine("Two demerits issued");
            } else if (difference > 0 && difference <= 5)
            {
                Console.WriteLine("One demerit issued");
            } else
            {
                Console.WriteLine("Ok");
            }
        }
    }
}
