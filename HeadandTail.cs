using System;

namespace BasicCoreProgramming.cs
{
    class HeadTailpercentage
    {
        public static int noFlip;
        public static int rem = 0, res = 0;

        public static void Flip()
        {
            //taking input no of flip from user
            Console.WriteLine("Enter no of times flip the coin");
            noFlip = Convert.ToInt32(Console.ReadLine());
        }

        public static void HeadTail()
        {
            HeadTailpercentage.Flip();
            int tail = 0, head = 0;
            Random random = new Random();
            for (int i = 1; i <= noFlip; i++)
            {
                int ran = random.Next(0, 2);
                {
                    if (ran == 0)
                    {
                        tail++;
                    }
                    else
                    {
                        head++;
                    }
                }
            }

            Console.WriteLine("Number of time head occures" + head);
            Console.WriteLine("Number of time tail occures" + tail);
            double percentHead = (double)head / noFlip * 100;
            Console.WriteLine("Head percentage is :" + percentHead);
            double percentTail = (double)tail / noFlip * 100;
            Console.WriteLine("Tail percentage is :" + percentTail);
        }
        static void Main(string[] args)
        {
            HeadTailpercentage.HeadTail();
            Console.ReadLine();
        }
    }
}
