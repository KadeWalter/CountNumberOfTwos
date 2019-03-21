using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 323;
            int count = CountAllTwos(number);

            Console.WriteLine("\nCount of 2s: " + count + "\n\n");
        }

        private static int CountAllTwos(int num)
        {
            int count = 0;
            for(int i = 0; i <= num; i++)
            {
                count += TwoInNum(i);
            }
            return count;
        }

        private static int TwoInNum(int num)
        {
            int count = 0;
            while(num > 0)
            {
                if(num % 10 == 2)
                    count++;
                num = num / 10;
            }
            return count;
        }
    }
}
