using System;

namespace DelenieBezOst
{
    class DelenieBezOst
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double sum3 = 0;
            double sum4 = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    sum++;
                }
                if (a % 3 == 0)
                {
                    sum3++;
                }
                if (a % 4 == 0)
                {
                    sum4++;
                }
            }
            double cnt2 = sum  / n * 100;
            double cnt3 = sum3 / n * 100;
            double cnt4 = sum4 / n * 100;

            Console.WriteLine($"{cnt2:f2}%");
            Console.WriteLine($"{cnt3:f2}%");
            Console.WriteLine($"{cnt4:f2}%");

        }
    }
}
