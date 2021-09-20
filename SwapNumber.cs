using System;

namespace BasicCoreProgramming.cs
{
    class SwapNumber
    {
        public static int temp;
        //Program to swap two numbers
        public static void Swapping()
        {
            //taking input from user
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping numbers are");
            Console.WriteLine("num1=" + num1);
            Console.WriteLine("num2=" + num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping numbers are");
            Console.WriteLine("num1=" + num1);
            Console.WriteLine("num2=" + num2);
        }

        static void Main(string[] args)
        {
            SwapNumber.Swapping();
            Console.ReadLine();
        }
    }
}