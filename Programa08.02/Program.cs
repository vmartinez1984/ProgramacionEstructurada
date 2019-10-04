using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int i;
            #endregion

            Console.WriteLine("Programa que muestra los números del 1 al 100");

            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine($"   {i}");
            }

            Console.ReadLine();
        }
    }
}
