using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._23
{
    /// <summary>
    /// 23.  Que calcule la media de X números, se dejarán de solicitar números hasta que se introduzca el cero.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula la media de X números, hasta que ingrese 0");

            #region Variables
            int totalDeNumeros = 0;
            double suma = 0;
            double media = 0;
            int numero = 1;
            #endregion

            while (numero != 0)
            {
                numero = LeerNumero();
                suma += numero;
                if (numero != 0)
                    totalDeNumeros++;
            }

            media = suma / totalDeNumeros;

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
