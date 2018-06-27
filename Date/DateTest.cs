using System;
using System.Collections.Generic;
using System.Text;

namespace Date
{
    class DateTest
    {
        static void Main(string[] args)
        {
            int month, day, year;
            Console.WriteLine("Please enter a day, month, and year to be displayed by a method: ");
            Console.WriteLine("Day: "); day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month: "); month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year: "); year = Convert.ToInt32(Console.ReadLine());

            Date myDate = new Date(month, day, year);
            Console.WriteLine("The date formatted is {0}", myDate.DisplayDate(month, day, year));
            Console.ReadKey();
        }
    }
}
