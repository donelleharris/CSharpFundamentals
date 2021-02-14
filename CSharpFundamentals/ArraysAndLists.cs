using System;
namespace CSharpFundamentals
{
    public class ArraysAndLists
    {
        public ArraysAndLists()
        {
            /*
             Single dimension arrays: 
                var numbers = new int[5];
                var numbers = new int[5] { 1, 2, 3, 4, 5 };
             Mulit Dimension Arrays:
                Rectangular: each row has the exact same number of columns
                    0 1 2 3 4
                    0 1 2 3 4
                    0 1 2 3 4

                    2D array declaration:
                        var matrix = new int[3, 5];
                      or...
                        var matrix = new int[3, 5]
                        {
                            { 1, 2, 3, 4, 5 }
                            { 10, 23, 37, 14, 54 }
                            { 13, 3, 7, 44, 5 }
                        };
                    Access individual element in a 2D array:
                        var element = matrix[0, 0]; [row, column]

                    3D Array declaration:
                        var colors = new int[3, 4, 5];

                Jagged: each row can have a different number of columns
                    0 1 2 3
                    0 1 2 3 4
                    0 1 2

                    Jagged array declaration:
                        var array = new int[3][]; [#ofRows][]
                        var array[0] = new int[4]; row index 0 has 4 columns
                        var array[1] = new int[5]; row index 1 has 5 columns
                        var array[2] = new int[2]; row index 2 has 2 columns

                    Access individual element in a jagged array:
                        var element = matrix[0, 0]; [row, column]
            */
            //var numbers = new[] { 3, 4, 6, 2, 12 };
            ////Length
            //Console.WriteLine("Length: " + numbers.Length);
            ////IndexOf()
            //Console.WriteLine("Index of 6: " + Array.IndexOf(numbers, 6));
            ////Clear
            //Array.Clear(numbers, 0, 2);
            //Console.Write("Result of Clear: ");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine("");

            //Copy
            //int[] another = new int[3];
            //Array.Copy(numbers, another, 3);
            //Console.Write("Result of Copy: ");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine("");

            //Sort()
            //var newArray = new[] { 23, 54, 11, 33, 90 };
            //Array.Sort(newArray);
            //Console.Write("newArray: ");
            //foreach (var n in newArray)
            //{
            //    Console.Write(n + " ");
            //}
            //Console.WriteLine("");
            //Console.Write("Result of Sort() on newArray: ");
            //foreach (var n in newArray)
            //{
            //    Console.Write(n + " ");
            //}
            //Console.WriteLine("");

            //Reverse()
            //Array.Reverse(newArray);
            //Console.Write("Result of Reverse() on newArray: ");
            //foreach (var n in newArray)
            //{
            //    Console.Write(n + " ");
            //}
            //Console.WriteLine("");

            /* 
            List: similar to an array but unlike an array which is a fixed size, a list has a dynamic size
            A List is generic but the type of list needs to be declared in the angle brackets <>.
            Empty List declaration: 
                var numbers = new List<int>();
            Specific List declaration:
                var numbers2 = new List<int>() { 1, 2, 3, 4, 5 };
            Most common methods available for Lists:
                Add() - adds to the end of a list
                AddRange() - adds multiple elements to a list, must be in array or list format
                Remove() - removes an element from a list
                RemoveAt() - removes an element at a specific index
                IndexOf() - returns the value of an element at a specific index
                Contains() - checks to see if a List contains a specific element
                Count - 
            */
            //var numberList = new List<int>() { 1, 2, 3, 4 };
            //Console.Write("numberList: ");
            //foreach (var n in numberList)
            //{
            //    Console.Write(n + " ");
            //}
            //Console.WriteLine("");
            //numberList.Add(1);
            //numberList.AddRange(new int[3] { 5, 6, 7 });
            //Console.Write("numberList: ");
            //foreach (var number in numberList)
            //{
            //    Console.Write(number + " ");

            //}
            //Console.WriteLine("");
            //Console.WriteLine("The index of 4 is " + numberList.IndexOf(4));
            //Console.WriteLine("Last index of 1 is " + numberList.LastIndexOf(1));
            //Console.WriteLine("Count: " + numberList.Count);



            //for (var i = 0; i < numberList.Count; i++)
            //{
            //    if (numberList[i] == 1)
            //        numberList.Remove(numberList[i]);
            //}

            //Console.Write("numberList: ");
            //foreach (var number in numberList)
            //{
            //    Console.Write(number + " ");

            //}

            //Console.WriteLine("");
            //numberList.Clear();
            //Console.WriteLine("Count: " + numberList.Count);
        }
    }
}
