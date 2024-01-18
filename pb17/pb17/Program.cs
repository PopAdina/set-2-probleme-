using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti secventa de 0 si 1 (0 = paranteza deschisa, 1 = paranteza inchisa): ");
            string input = Console.ReadLine();
            int maxLevel = 0;
            int currentLevel = 0;
            foreach (char c in input)
            {
                if (c == '0')
                {
                    currentLevel++;
                }
                else if (c == '1')
                {
                    if (currentLevel > 0)
                    {
                        currentLevel--;
                    }
                    else
                    {
                        Console.WriteLine("Secvenata este incorecta.");
                        Console.ReadLine();
                        return;
                    }
                }
                maxLevel = Math.Max(maxLevel, currentLevel);
            }
            if (currentLevel == 0)
            {
                Console.WriteLine("Secvenata este corecta si nivelul maxim de incuibare este " + maxLevel + ".");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Secventa este incorecta.");
                Console.ReadLine();
            }

        }
    }
}
