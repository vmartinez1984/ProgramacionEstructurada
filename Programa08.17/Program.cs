using System;

namespace Programa08._17
{
    /// <summary>
    /// 17.  Que muestre los números del 1 al 100 en una tabla de 10x10.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            int length = 10;
            int numero = 1;
            #endregion
            Console.WriteLine("17.- Programa que muestra los números del 1 al 100 en tabla de 10 x 10");
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(numero.ToString().PadLeft(4,' '));
                    numero++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
