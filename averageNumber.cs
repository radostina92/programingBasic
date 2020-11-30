using System;

namespace AverageNumber
{
    class averageNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            double average = sum / n;
            Console.WriteLine($"{average:f2}");
        }
    }
}
