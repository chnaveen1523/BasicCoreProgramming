using System;

namespace BasicCoreProgramming.cs
{
    class PrimeFactorization
    {
        //Find prime factors of a number
        public static void PrimeFactor()
        {
            //taking input from user
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            //local variable
            int isPrime;
            for (int count = 2; count <= num; count++)
            {
                if (num % count == 0)
                {
                    isPrime = 1;
                    for (int j = 2; j <= count / 2; j++)
                    {
                        if (count % j == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine("Prime factor is" + count);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            PrimeFactorization.PrimeFactor();
            Console.ReadLine();
        }
    }
}