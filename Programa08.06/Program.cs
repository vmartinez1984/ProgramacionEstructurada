using System;

namespace Programa08._06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int i;
            int suma = 0;
            #endregion

            Console.WriteLine("Programa que muestra la suma del 1 al 100");

            for (i = 1; i <= 100; i++)
            {
                suma = suma + i;                
            }

            Console.WriteLine($"Total: {suma}");
            Console.ReadLine();
        }
    }
}
