using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int i;
            int suma = 0;
            int modulo = 0;
            #endregion

            Console.WriteLine("Programa que muestra la suma de los números pares 1 al 100");

            for (i = 1; i <= 100; i++)
            {
                modulo = i % 2;
                if (modulo == 0)
                {
                    suma = suma + i;
                }
            }

            Console.WriteLine($"Total: {suma}");
            Console.ReadLine();
        }//Main
    }//Program
}//namespace