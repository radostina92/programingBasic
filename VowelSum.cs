using System;

namespace VowelSum
{
    class VowelSum
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            
            var sum = 0;
            for (int j = 0; j < text.Length; j++)
            {
               if (text[j] == 'a')
                {
                    sum += 1;
                }
               else if (text[j] == 'e')
                {
                    sum += 2;
                }
               else if (text[j] == 'i')
                {
                    sum += 3;
                }
               else if (text[j] == 'o')
                {
                    sum += 4;
                }
               else if (text[j] == 'u')
                {
                    sum += 5;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
