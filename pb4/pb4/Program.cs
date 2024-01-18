using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul cautat: ");
            int a = int.Parse(Console.ReadLine());
            int pozitie = CautaNumar(n, a);
            if (pozitie != -1)
            {
                Console.WriteLine($"Numarul {a} se afla pe pozitia {pozitie}.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Numarul {a} nu se afla in secventa.Rezultat : -1");
                Console.ReadLine();
            }
        }
        static int CautaNumar(int lungime, int numarCautat)
        {
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introduceti elementul {i} din secventa: ");
                int numar = int.Parse(Console.ReadLine());
                if (numar == numarCautat)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
