using System;

namespace LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < n; i++)
            {
                num1 = num1 + int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n; j++)
            {
                num2 = num2 + int.Parse(Console.ReadLine());
            }
            if (num1 == num2)
            {
                Console.WriteLine($"Yes, sum = {num1}");
            }
            else
            {
                int newSum = Math.Abs(num1 - num2);
                Console.WriteLine($"No, diff = {newSum}");
            }

        }
    }
}
