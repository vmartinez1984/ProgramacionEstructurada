using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progrma08._16
{
    /// <summary>
    /// 16.  Que pida un número y muestre en pantalla el mismo número de asteriscos.
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

            Console.WriteLine("15.- Programa que escribe el mismo número de asteriscos que el numero ingresado");
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

            for (int i = 0; i < numeroA; i++)
            {
                Console.Write("*");
            }

            Console.ReadLine();
        }//Main
    }//Program
}//namespace