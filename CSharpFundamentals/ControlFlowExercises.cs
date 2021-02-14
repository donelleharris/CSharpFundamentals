using System;
namespace CSharpFundamentals
{
    public class ControlFlowExercises
    {
        public ControlFlowExercises()
        {
            /* Write a program to count how many numbers between 1 and 100 are 
            divisible by 3 with no remainder. Display the count on the console. */
            //var count = 0;

            //for(var i = 0; i <= 100; i++)
            //{
            //    if(i % 3 == 0)
            //        {
            //            count++;
            //        }
            //}
            //Console.WriteLine(count);

            /*Write a program and continuously ask the user to enter a number 
             or "ok" to exit. Calculate the sum of all the previously entered 
             numbers and display it on the console.*/

            //var addUp = 0;
            //while (true)
            //{
            //    Console.WriteLine("Please enter a number or type \"ok\" to exit: ");
            //    var input = Console.ReadLine();
            //    if (input == "ok")
            //        break;

            //    int.TryParse(input, out int n);
            //    addUp += n;
            //}
            //Console.WriteLine("The sum of numbers entered is: " + addUp);

            /*Write a program and ask the user to enter a number. Compute the 
             factorial of the number and print it on the console. For example,
             if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1
             and display it as 5! = 120.*/
            //Console.WriteLine("Please enter a number less than 20: ");
            //int userInput = int.Parse(Console.ReadLine());
            //int factorial = 1;
            //for(var i = userInput; i > 0; i--)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine(userInput + "! = " + factorial);

            /*Write a program that picks a random number between 1 and 10. Give 
             the user 4 chances to guess the number. If the user guesses the
             number, display “You won"; otherwise, display “You lost". (To make
             sure the program is behaving correctly, you can display the secret
             number on the console first.)*/

            //var secretNumber = new Random().Next(1, 10);

            //for (var i = 0; i < 4; i++)
            //{
            //    Console.Write("Guess the secret number (1 - 10): ");
            //    var userGuess = Convert.ToInt32(Console.ReadLine());

            //    if (userGuess == secretNumber)
            //    {
            //        Console.WriteLine("You won! The secret number was " + secretNumber);
            //        return;
            //    }
            //}
            //Console.WriteLine("You lost!");

            /*Write a program and ask the user to enter a series of numbers 
             separated by comma. Find the maximum of the numbers and display 
             it on the console. For example, if the user enters “5, 3, 8, 1, 4", 
             the program should display 8.*/
            //Console.WriteLine("Enter 5 numbers separated by a comma: ");
            //var userNumbers = Console.ReadLine();
            //var numbers = userNumbers.Split(',');
            //var max = Convert.ToInt32(numbers[0]);
            //foreach(var number in numbers)
            //{
            //    var item = Convert.ToInt32(number);
            //    if(item > max)
            //        max = item;
            //}
            //Console.WriteLine("Largest number is: " + max);

        }
    }
}
