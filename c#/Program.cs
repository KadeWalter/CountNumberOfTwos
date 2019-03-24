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

        private static int NumOfTwosFromNum(int num)
        {
            int count = 0;
            // 323 = 167
            // 23 = 7

            // 300 means 100 2's just from 200
            // 10 2's from 0 to 100 in the 1's place
            // 10 2's from 0 to 100 in the 10's place
            

            // FOR 23: TO GET 7
            // 10's place count = (higher(0 in this case) * 10) + (lower + 1)
            // -> (0 * 10) + (3 + 1) = 4
            // 1's place count = (highest * 10) + (higher + 1 if >= 2 in row, higher if < 2 in row) 
            // -> (0 * 10) + (2 + 1) = 3

            string numAsString = num.ToString();
            int[] arr = new int[numAsString.Length];
            for(int i = 0; i < numAsString.Length; i++)
                arr[i] = Convert.ToInt32(numAsString.Substring(i,1));
            return count;
        }
    }
}
