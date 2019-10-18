using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._25
{
    /// <summary>
    /// 25.  Que escriba los primeros 25 dígitos de la sucesión de Fibonacci.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que escribe los primeros 25 números de la sicesión Fibonacci");
            int x, y, z, cont;

            x = 0;
            y = 1;

            for (cont = 1; cont <= 25; cont = cont + 1)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
            }

            Console.ReadLine();
        }
    }
}
