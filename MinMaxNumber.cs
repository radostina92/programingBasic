using System;

namespace MinMaxNumber
{
    class MinMaxNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int MaxNum = int.MinValue;
            int minNum = 1000000000;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a > MaxNum)
                {
                    MaxNum = a;
                }
            }
            Console.WriteLine(MaxNum);
        }
    }
}
