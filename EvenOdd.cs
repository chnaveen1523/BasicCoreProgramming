using System;

namespace BasicCoreProgramming.cs
{
    class EvenOdd
    {
        //Program to check number is a even or odd
        public static void NumberCheck()
        {
            //Take input from user
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The given number is a even number");
            }
            else
            {
                Console.WriteLine("The given number is a odd number");
            }

        }

        static void Main(string[] args)
        {
            EvenOdd.NumberCheck();
            Console.ReadLine();
        }
    }
}