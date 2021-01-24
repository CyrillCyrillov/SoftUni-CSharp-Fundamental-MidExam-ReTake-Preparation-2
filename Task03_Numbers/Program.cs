using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            double averageNumber = numbers.Sum() / numbers.Count;

            int counter = 0;

            foreach (int element in numbers.OrderByDescending(x => x))
            {
                
                if(element > averageNumber)
                {
                    Console.Write(element);
                    counter++;
                    if (counter < 5)
                    {
                        Console.Write(' ');
                    }
                }

                if(counter >= 5)
                {
                    break;
                }
            }

            if(counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
