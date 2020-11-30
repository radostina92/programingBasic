using System;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            int water = 20;
            int internet = 15;
            double others = 0;
            double sum = 0;
            double sumEl = 0;
            double sumOthers = 0;
            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                sumEl = sumEl + electricity;
                sum = electricity + water + internet;
                others = sum + (sum * 0.20);
                sumOthers += others;
                
            }
            int newWater = months * water;
            int newInternet = months * internet;
            double newOthers = others * months;
            double average = (sumOthers + newInternet + newWater + sumEl) / months;

            Console.WriteLine($"Electricity: {sumEl:f2} lv");
            Console.WriteLine($"Water: {newWater:f2} lv");
            Console.WriteLine($"Internet: {newInternet:f2} lv");
            Console.WriteLine($"Other: {sumOthers:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");



        }
    }
}
