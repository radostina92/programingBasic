using System;
using System.Security.Cryptography;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > maxNum)
                {
                    maxNum = num;
                    
                }
                
            }
            sum = sum - maxNum;
            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                int newSum = Math.Abs(sum - maxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {newSum}");
            }
        }
    }
}
