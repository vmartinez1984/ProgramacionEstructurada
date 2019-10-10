using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._22
{
    /// <summary>
    /// 22.  Que calcule la media de 10 números.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            #region Variables
            double suma = 0;
            double media;
            int totalDenumeros = 10;
            #endregion

            Console.WriteLine($"Programa que calcula la media de {totalDenumeros} números");

            for (int i = 0; i < totalDenumeros; i++)
            {
                suma += LeerNumero();
            }
            media = suma/ totalDenumeros;

            Console.WriteLine($"El promedio es: {media}");
            Console.ReadLine();
        }

        static int LeerNumero()
        {
            int numeroA;
            string strNumero = string.Empty;
            bool isNumero = false;

            #region Número desde teclado
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
            #endregion

            return numeroA;
        }
    }
}
