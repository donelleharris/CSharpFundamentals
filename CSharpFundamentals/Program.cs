using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    //Enums lecture
    //public enum ShippingMethod
    //{
    //    RegularAirMail = 1,
    //    RegisteredAirMail = 2,
    //    Express = 3
    //}
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Types:
             *  Structures(value types) - primitive types, custom structures
             *  Classes(reference types) - arrays, strings, custom classes
            */
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(array1[0]);

            //Enum lecture
            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);
            //Console.WriteLine(method.ToString());

            //var methodName = "Express";
            //var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            //Strings Lecture
            //var fName = "Donelle";
            //var lName = "Brown";
            //var fullName = fName + " " + lName;
            //var myFullName = string.Format("My name is {0} {1}", fName, lName);
            //var names = new string[3] { "John", "Jack", "Mary" };
            //var formattedNames = string.Join(", ", names);

            //var text = "Hello John\nLook into the following paths\nc:\\folder1\\folder2\\folder3\\filename";
            ////or...
            //var formattedText = @"Hello John
            //                    Look into the following paths
            //                    c:\folder1\folder2\folder3\filename";


            //Arrays Lecture
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

            //Classes lecture
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
