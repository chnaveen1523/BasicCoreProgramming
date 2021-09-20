using System;

namespace BasicCorePrograms_CS
{/
    class LargestNumber
    {
        //Program to find largest among three numbers
        public static void Largest()
        {
            //taking input from user
            Console.WriteLine("Enter first numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second numbers:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third numbers:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("{0} is the largest number", +num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("{0} is the largest number", +num2);
            }
            else
            {
                Console.WriteLine("{0} is the largest number", +num3);
            }
        }

        static void Main(string[] args)
        {
            LargestNumber.Largest();
            Console.ReadLine();
        }
    }
}