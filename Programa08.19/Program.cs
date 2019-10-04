using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._19
{
    /// <summary>
    /// 19.  Que muestre la tabla de multiplicar de un número cualquiera.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            string strNumero = string.Empty;
            int numeroA = 0;
            bool isNumero = false;
            #endregion
            Console.WriteLine("19. Programa que muestra la tabla de multiplicar de un numero ingresado");
            do
            {
                Console.Write("Escriba el número: ");
                strNumero = Console.ReadLine();
                isNumero = Int32.TryParse(strNumero, out numeroA);
                if (!isNumero)
                {
                    Console.WriteLine("no es un número entero, intente nuevamente");
                }
            } while (!isNumero);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numeroA.ToString().PadLeft(5,' ')} X{i.ToString().PadLeft(2, ' ')} = {(i*numeroA).ToString().PadLeft(5,' ').PadRight(5,' ')}");
            }

            Console.ReadLine();
        }
    }
}
