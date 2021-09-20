using System;

namespace BasicCoreProgramming.cs
{
    class PowerOf2
    {
        public static void PowerCalci()
        {
            //taking input from user
            Console.WriteLine("Enter the power of 2 till you want to display");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int count = 1; count <= num; count++)
            {
                //using Math.Pow method() to calulate power
                //Pow method(2,count) means 2 to the power count
                double pow = Math.Pow(2, count);
                Console.WriteLine("power of 2 of {0} is {1}", +count, +pow);
            }
        }
        static void Main(string[] args)
        {
            PowerOf2.PowerCalci();
            Console.ReadLine();
        }
    }
}