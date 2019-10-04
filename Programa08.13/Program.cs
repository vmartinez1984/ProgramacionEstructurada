using System;

namespace Programa08._13
{

    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            string strNumero = string.Empty;
            int numeroA = 0;
            int numeroB = 0;
            bool isNumero = false;
            #endregion
            Console.WriteLine("13. Programa que muestra el intervalo de impares de dos números enteros");
            do
            {
                Console.Write("Escriba el primer número: ");
                strNumero = Console.ReadLine();
                isNumero = Int32.TryParse(strNumero, out numeroA);
                if (!isNumero)
                {
                    Console.WriteLine("no es un número entero, intente nuevamente");
                }
            } while (!isNumero);

            do
            {
                Console.Write("Escriba el segundo número: ");
                strNumero = Console.ReadLine();
                isNumero = Int32.TryParse(strNumero, out numeroB);
                if (!isNumero)
                {
                    Console.WriteLine("no es un número entero, intente nuevamente");
                }
                else if (numeroB > numeroA)
                {
                    //Todo esta correcto
                }
                else
                {
                    Console.WriteLine($"Debe ser mayor a {numeroA}, intente nuevamente");
                    isNumero = false;
                }
            } while (!isNumero);

            for (int i = numeroA; i <= numeroB; i++)
            {
                if ((i % 2) == 1)
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }//Main
    }//Program
}//namespace