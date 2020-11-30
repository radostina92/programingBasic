using System;

namespace AreasOffigures
{
    class AreasOffigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double side = double.Parse(Console.ReadLine());
            if (figure == "square")
            {
                Console.WriteLine(side * side);
            }
            else if (figure == "rectangle")
            {
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(side * height);
            }
            else if (figure == "circle")
            {
                double pi = Math.PI; 
                Console.WriteLine("{0:f3}",pi * side * side);
            }
            else if (figure == "triangle")
            {
                double height2 = double.Parse(Console.ReadLine());
                Console.WriteLine( (side * height2) / 2);
            }
        }
    }
}
