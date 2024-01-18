using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            long produs = 1;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n}: {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n}: {produs}");
            Console.ReadLine();
        }
    }
}
