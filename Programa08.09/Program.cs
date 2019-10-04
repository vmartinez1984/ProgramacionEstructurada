using System;

namespace Programa08._09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int i;
            int suma = 0;
            int modulo = 0;
            int paresTotal = 0;
            #endregion

            Console.WriteLine("09.- Programa que muestra la suma de los números pares 1 al 100 eindica cuantos hay");

            for (i = 1; i <= 100; i++)
            {
                modulo = i % 2;
                if (modulo == 0)
                {
                    suma = suma + i;
                    paresTotal++;
                }
            }

            Console.WriteLine($"Total: {suma}");
            Console.WriteLine($"Hay {paresTotal} números pares");
            Console.ReadLine();
        }//Main
    }//Program
}//namespace