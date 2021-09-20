using System;

namespace BasicCoreProgramming.cs
{
    class Quotient
    {
        public static int rem = 0, res = 0;

        public static void FindQuotientRem()
        {
            //taking input of dividend and divisor from user
            Console.WriteLine("Enter dividend=");
            int div = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor=");
            int divisor = Convert.ToInt32(Console.ReadLine());
            res = div / divisor;
            rem = div % divisor;
            Console.WriteLine("{0} and {1} is the quotient and remainder of {2}", +res, +rem, +div);
        }

        static void Main(string[] args)
        {
            Quotient.FindQuotientRem();
            Console.ReadLine();
        }
    }
}