using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fName = "Donelle";
            var lName = "Brown";
            var fullName = fName + " " + lName;
            var myFullName = string.Format("My name is {0} {1}", fName, lName);
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);

            var text = "Hello John\nLook into the following paths\nc:\\folder1\\folder2\\folder3\\filename";
            //or...
            var formattedText = @"Hello John
                                Look into the following paths
                                c:\folder1\folder2\folder3\filename";
            //var numbers = new int[3];
            //numbers[0] = 1;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;

            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);

            //var names = new string[3] { "Jack", "John", "Mary" };


            //var john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();

            //Math.Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);
        }
    }
}
