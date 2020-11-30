using System;

namespace Groups
{
    class Groups
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a < 200)
                {
                    sum++;
                }
              else  if (a >= 200 && a <= 399)
                {
                    sum2++;
                }
               else if (a >= 400 && a <= 599)
                {
                    sum3++;
                }
               else  if (a >= 600 && a <= 799)
                {
                    sum4++;
                }
                else if (a >= 800)
                    {
                    sum5++;
                    
                }
            }
            double cnt2 = sum / n * 100;
            double cnt3 = sum2 / n * 100;
            double cnt4 = sum3 / n * 100;
            double cnt5 = sum4 / n * 100;
            double cnt6 = sum5 / n * 100;

            Console.WriteLine($"{cnt2:f2}%");
            Console.WriteLine($"{cnt3:f2}%");
            Console.WriteLine($"{cnt4:f2}%");
            Console.WriteLine($"{cnt5:f2}%");
            Console.WriteLine($"{cnt6:f2}%");
        }
    }
}
