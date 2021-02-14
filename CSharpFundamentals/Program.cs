﻿using System;
using System.Collections.Generic;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Formatting Strings:
             *    .ToLower() returns string in all lowercase characters
             *    .ToUpper() returns string in all uppercase characters
             *    .Trim() trims leading and trailing whitespace characters
             * Searching Strings:
             *    .IndexOf() returns the first index of a given character or set of characters in a string
             *    .LastIndexOf() returns the last index of a given character or set of characters in a string
             * Substrings:
             *    .Substring(startIndex) returns the remaining characters of a string from a specific index start point
             *    .Substring(startIndex, length) returns a set number of characters of a string from a specific index start point
             * Replace:
             *    .Replace('a', '!') replaces first character with last character (i.e. all 'a' characters become '!' throughout the string)
             *    .Replace("mosh", "moshfegh") replaces all instances of "mosh" with "moshfegh" throughout the string
             * Null checking:
             *    String.IsNullOrEmpty(str) checks passed string parameter for empty string ""
             *    String.IsNullOrWhiteSpace(str) checks passed string parameter for empty string or string of only whitespace characters
             * Splitting:
             *    str.Split(' ') 
             * Converting strings to numbers:
             *    int.Parse()
             *    Convert.ToInt32() this is the preferred method since it will convert an empty string to 0
             * Converting numbers to strings:
             *    .ToString() converts directly to string
             *    .ToString("C") converts to currency (i.e. $1234.00)
             *    .ToString("C0") converts to currency without trailing decimal places
             *        format specifiers: 
             *          c or C - currency
             *          d or D - decimal
             *          e or E - exponential
             *          f or F - fixed point
             *          x or X - hexadecimal
             */

            //var fullName = "Donelle Harris ";
            //Console.WriteLine("Without Trim: '{0}'", fullName);
            //Console.WriteLine("Trim: '{0}'", fullName.Trim());
            //Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            //var index = fullName.IndexOf(' ');
            //var firstName = fullName.Substring(0, index);
            //var lastName = fullName.Substring(index + 1);
            //Console.WriteLine(firstName);
            //Console.WriteLine(lastName);

            var sentence = "This is going to be a really really really really really really really really really really long sentence.";
            var summary = SummarizeText(sentence);
            Console.WriteLine(summary);
        }
        static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            return String.Join(" ", summaryWords) + "...";
            
            
        }
    }
}
