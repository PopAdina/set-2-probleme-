using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int negativeCount = 0;
            int zeroCount = 0;
            int positiveCount = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    negativeCount++;
                }
                else if (num == 0)
                {
                    zeroCount++;
                }
                else
                {
                    positiveCount++;
                }
            }
            Console.WriteLine($"Numere negative: {negativeCount}");
            Console.WriteLine($"Numere zero: {zeroCount}");
            Console.WriteLine($"Numere pozitive: {positiveCount}");
        }
    }
}
