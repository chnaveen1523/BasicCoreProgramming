using System;

namespace BasicCoreProgramming.cs
{
    class VowelConsonant
    {
        //Program to check alphabate is a vowel or consonant
        public static void AlphabateCheck()
        {
            //Take input from user
            Console.WriteLine("Enter a alphabate:");
            char alpha = Convert.ToChar(Console.ReadLine());
            //To check input is a vowel or consonant
            if (alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u' || alpha == 'A' || alpha == 'E' || alpha == 'I' || alpha == 'O' || alpha == 'U')
            {
                Console.WriteLine("It is a Vowel");
            }
            else
            {
                Console.WriteLine("It is a Consonant");
            }

        }

        static void Main(string[] args)
        {
            VowelConsonant.AlphabateCheck();
            Console.ReadLine();
        }
    }
}