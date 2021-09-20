using System;

namespace BasicCoreProgramming.cs
{
    class LeapYear
    {
        public static void leap()
        {
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 400) == 0) || ((year % 4) == 0) && ((year % 100) != 0))
            {
                Console.WriteLine("{0} is a leap year", +year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", +year);
            }
        }
        static void Main(string[] args)
        {
            LeapYear.leap();
            Console.ReadLine();
        }
    }
}