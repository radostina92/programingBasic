using System;

namespace CleverLilly
{
    class CleverLilly
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double bdaysMoney = 0;
            double moneyGift = 10.00;
            double toys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    bdaysMoney += moneyGift;
                    moneyGift += 10;
                    bdaysMoney--;
                }
                else
                {
                    toys++;
                }

            }
            double totalMoneyToys = toys * toyPrice;
            double totalMoney = totalMoneyToys + bdaysMoney;
            
            if (totalMoney >= washPrice)
            {
                Console.WriteLine($"Yes! {totalMoney - washPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washPrice - totalMoney:f2}");
            }
        }
    }
}
