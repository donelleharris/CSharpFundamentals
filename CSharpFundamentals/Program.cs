using System;
using System.Collections.Generic;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Dates & Time in C#
            
            var dateTime = new DateTime(2021, 2, 14);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Today: " + today);
            Console.WriteLine("Hour: " + now.Hour + " Minute: " + now.Minute);

            //roll forward/back a day:
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("");
            Console.WriteLine("ToLongDateString: " + now.ToLongDateString());
            Console.WriteLine("ToShortDateString: " + now.ToShortDateString());
            Console.WriteLine("ToLongTimeString: " + now.ToLongTimeString());
            Console.WriteLine("ToShortTimeString: " + now.ToShortTimeString());
            Console.WriteLine("ToString in dd-MMM-yyyy format: " + now.ToString("dd-MMM-yyyy"));

            //TimeSpan
            var timeSpan = new TimeSpan(1, 2, 3);//days, hours, minutes

            var start = DateTime.Now;
            var end = start.AddMinutes(120);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //add
        }
    }
}
