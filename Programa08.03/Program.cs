using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int i;
            #endregion

            Console.WriteLine("Programa que muestra los números del 100 al 1");

            for (i = 100; i >= 1; i--)
            {
                Console.WriteLine($"   {i}");
            }

            Console.ReadLine();
        }//
    }
}