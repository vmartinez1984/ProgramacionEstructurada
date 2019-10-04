using System;

namespace Programa08._10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int i;
            int suma = 0;
            int modulo = 0;
            int imparesTotal = 0;
            #endregion

            Console.WriteLine("10.- Programa que muestra la suma de los números impares 1 al 100 e indica cuantos hay");

            for (i = 1; i <= 100; i++)
            {
                modulo = i % 2;
                if (modulo == 1)
                {
                    suma = suma + i;
                    imparesTotal++;
                }
            }

            Console.WriteLine($"Total: {suma}");
            Console.WriteLine($"Hay {imparesTotal} números impares");
            Console.ReadLine();
        }//Main
    }//Program
}//namespace