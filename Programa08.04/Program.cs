using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int i;
            int modulo = 0;
            #endregion

            Console.WriteLine("Programa que muestra los números pares del 1 al 100");

            for (i = 1; i <= 100; i++)
            {
                modulo = i % 2;
                if (modulo == 0)
                {
                    Console.WriteLine($"   {i}");
                }
            }

            Console.ReadLine();
        }
    }
}
