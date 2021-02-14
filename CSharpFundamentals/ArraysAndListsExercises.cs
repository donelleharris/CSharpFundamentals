using System;
namespace CSharpFundamentals
{
    public class ArraysAndListsExercises
    {
        public ArraysAndListsExercises()
        {
            /*
             When you post a message on Facebook, depending on the number of 
             people who like your post, Facebook displays different information.
                * If no one likes your post, it doesn't display anything.
                
                * If only one person likes your post, it displays: [Friend's Name] 
                  likes your post.
                * If two people like your post, it displays: [Friend 1] and 
                  [Friend 2] like your post.
                * If more than two people like your post, it displays: [Friend 1], 
                  [Friend 2] and [Number of Other People] others like your post.

             Write a program and continuously ask the user to enter different names,
             until the user presses Enter (without supplying a name). Depending on
             the number of names provided, display a message based on the above pattern.
             */
            //var friendsList = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("Enter friend's name: ");
            //    var friend = Console.ReadLine();
            //    if (friend != "")
            //    {
            //        friendsList.Add(friend);
            //        continue;
            //    }
            //    else break;
            //}
            //switch (friendsList.Count)
            //{
            //    case 1:
            //        Console.WriteLine(friendsList[0] + " likes your post.");
            //        break;
            //    case 2:
            //        Console.WriteLine(friendsList[0] + " & " + friendsList[1] + " like your post.");
            //        break;
            //    default:
            //        Console.WriteLine(friendsList[0] + ", " + friendsList[1] + " & " + (friendsList.Count - 2) + " others like your post.");
            //        break;

            //}

            /*
             Write a program and ask the user to enter their name. Use an array 
             to reverse the name and then store the result in a new string.
             Display the reversed name on the console.
            */
            //Console.WriteLine("Please enter your name: ");
            //var userName = Console.ReadLine();
            //char[] nameArray = userName.ToCharArray();
            //Array.Reverse(nameArray);
            //Console.WriteLine(new string(nameArray));

            /*
             Write a program and ask the user to enter 5 numbers. If a number has
             been previously entered, display an error message and ask the user
             to re-try. Once the user successfully enters 5 unique numbers, sort
             them and display the result on the console.
            */
            //var userNumbers = new List<int>();
            //while(userNumbers.Count < 5)
            //{
            //    Console.WriteLine("Please enter a number: ");
            //    var input = Convert.ToInt32(Console.ReadLine());
            //    if (userNumbers.Contains(input))
            //    {
            //        Console.WriteLine(input + " has already been entered.");
            //        continue;
            //    }
            //    userNumbers.Add(input);
            //}
            //userNumbers.Sort();
            //Console.WriteLine("");
            //Console.Write("Your numbers were: ");
            //var numberArray = new Array[userNumbers.Count];
            //foreach(var number in userNumbers)
            //{
            //    Console.Write(number + " ");
            //}

            /*
             Write a program and ask the user to continuously enter a number or
             type "Quit" to exit. The list of numbers may include duplicates.
             Display the unique numbers that the user has entered.
            */
            //var list = new List<string>();
            //Console.WriteLine("Please enter a number or \"quit\" to exit: ");
            //var input = (Console.ReadLine());
            //while(input != "quit")
            //{
            //    list.Add(input);
            //    Console.WriteLine("Please enter a number or \"quit\" to exit: ");
            //    input = (Console.ReadLine());
            //}
            //var uniqueList = new HashSet<string>(list);
            //foreach(string u in uniqueList)
            //{
            //    Console.WriteLine(u);
            //}

            /*
             Write a program and ask the user to supply a list of comma separated
             numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less
             than 5 numbers, display "Invalid List" and ask the user to re-try;
             otherwise, display the 3 smallest numbers in the list.
            */
            //string[] elements;
            //while (true)
            //{
            //    Console.Write("Enter a list of comma-separated numbers: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        elements = input.Split(',');
            //        if (elements.Length >= 5)
            //            break;
            //    }

            //    Console.WriteLine("Invalid List");
            //}

            //var numbers = new List<int>();
            //foreach (var number in elements)
            //    numbers.Add(Convert.ToInt32(number));

            //var smallests = new List<int>();
            //while (smallests.Count < 3)
            //{
            //    // Assume the first number is the smallest
            //    var min = numbers[0];
            //    foreach (var number in numbers)
            //    {
            //        if (number < min)
            //            min = number;
            //    }
            //    smallests.Add(min);

            //    numbers.Remove(min);
            //}

            //Console.WriteLine("The 3 smallest numbers are: ");
            //foreach (var number in smallests)
            //    Console.WriteLine(number);

        }
    }
}
