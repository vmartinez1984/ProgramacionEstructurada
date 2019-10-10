using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._21
{
    /// <summary>
    /// 21.  Que calcule el factorial de un número cualquiera y lo muestre en pantalla.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int numeroA;
            int numeroB;
            string strNumero = string.Empty;
            bool isNumero = false;
            #endregion

            Console.WriteLine("Programa que calcula el factorial de un número ingresado");

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


            #region Calculo de factorial
            numeroB = numeroA;
            while (numeroB != 1)
            {
                numeroB = numeroB - 1;
                numeroA = numeroA * numeroB;
            }
            #endregion

            Console.Write($"El factorial es: {numeroA}");

            Console.ReadLine();            
        }
    }
}
