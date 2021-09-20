using System;

namespace BasicCoreProgramming.cs
{
    class HarmonicNumber
    {
        public static double sum = 0.0;

        public static void HarmonicNumb()
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (double count = 1; count <= num; count++)
            {
                sum = sum + 1 / count;
            }
            Console.WriteLine("The Nth harmonic series is:" + sum);
        }
        static void Main(string[] args)
        {
            HarmonicNumber.HarmonicNumb();
            Console.ReadLine();
        }
    }
}