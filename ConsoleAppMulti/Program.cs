using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMulti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double multi = 1;
            int cont = 1;
            Console.Write("Informe qual número você quer os múltiplos: ");
            double vezes = double.Parse(Console.ReadLine());
            while (multi <= 90) {
                multi = cont * vezes;
                Console.WriteLine(multi);
                cont++;
            }
            Console.ReadKey();
        }
    }
}
