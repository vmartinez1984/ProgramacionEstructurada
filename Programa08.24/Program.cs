using System;

namespace Programa08._24
{
    class Program
    {
        /// <summary>
        /// 24.  Que calcule la suma de los cuadrados de los 100 primeros números.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula  la suma de los cuadrados de los primeros 100 números");

            int i;
            int suma =0;

            for (i = 1; i <= 100; i++)
            {
                suma = suma + (i * i);
            }

            Console.WriteLine($"El resultado es: {suma}");
            Console.ReadKey();
        }
    }
}
