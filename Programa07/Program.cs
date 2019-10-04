using System;

namespace Programa07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string strNumero = string.Empty;
            double numero = 0;
            bool isNumero = false;
            int totalDeNumeros = 1;
            double suma = 0;
            #endregion

            #region Operaciones e ingreso de datos
            Console.WriteLine("Programa que calcula la suma de N números.");
            Console.WriteLine("Ingrese el numero y luego presione enter,");
            Console.Write("cuando desee visualizar el resultado escriba = y luego enter");
            Console.WriteLine();
            Console.WriteLine();
            do
            {
                Console.Write($"Anote el {totalDeNumeros}° número: ");
                strNumero = Console.ReadLine();
                isNumero = double.TryParse(strNumero, out numero);
                if (strNumero != "=")
                    if (isNumero)
                    {
                        suma = suma + numero;
                        totalDeNumeros++;
                    }
                    else
                    {
                        Console.WriteLine("No es un número, intente nuevamente");
                        Console.ReadLine();
                    }
            } while (strNumero != "=");
            #endregion

            #region Resultado
            Console.WriteLine($"La suma es: {suma}");
            Console.ReadLine();
            #endregion
        }//Main
    }//Program07
}//namespace