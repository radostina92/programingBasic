using System;
using System.Threading;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string item = Console.ReadLine();
            double ribbon = 0;
           
            double grade = 0;
            
            if (country == "Bulgaria")
            {
                if (item == "ribbon")
                {
                    ribbon = 9.600 + 9.400;

                }
                else if (item == "hoop")
                {
                    ribbon = 9.550 + 9.750;
                }
                else if(item == "rope")
                {
                    ribbon = 9.500 + 9.400;

                }
            }
            else if (country == "Russia")
            {
                if (item == "ribbon")
                {
                    ribbon = 9.100 + 9.400;

                }
                else if (item == "hoop")
                {
                    ribbon = 9.300 + 9.800;
                }
                else if (item == "rope")
                {
                    ribbon = 9.000 + 9.600;
                }
            }
            else if (country == "Italy")
            {
                if (item == "ribbon")
                {
                    ribbon = 9.200 + 9.500;
                }
                else if (item == "hoop")
                {
                    ribbon = 9.450 + 9.350;
                }
                else if (item == "rope")
                {
                    ribbon = 9.700 + 9.150;
                }
            }
            grade = 20 - ribbon;
            double newGrade = (grade / 20) * 100;
         
           
            Console.WriteLine($"The team of {country} get {ribbon:f3} on {item}.");
            Console.WriteLine($"{newGrade:f2}%");


        }
    }
}
