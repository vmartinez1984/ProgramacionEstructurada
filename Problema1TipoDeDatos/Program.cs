using System;

namespace Problema1TipoDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            double limiteInferior = 100;
            double limiteSuperior = 200;
            string strNumero = string.Empty;
            double numero = 0;
            bool isNumero = false;
            #endregion

            Console.WriteLine($"Programa que indica si un número esta entre el limite inferior ");
            Console.Write($"{ limiteInferior} y el limite superior {limiteSuperior}");
            Console.WriteLine();
            Console.WriteLine("Escriba un número: ");
            strNumero = Console.ReadLine();
            isNumero = double.TryParse(strNumero, out numero);
            if (isNumero)
            {
                if (numero < limiteInferior)
                {
                    Console.WriteLine("El número es menor al limite inferior");
                }
                else if (numero == limiteInferior)
                {
                    Console.WriteLine("El número esta en el limite inferior");
                }
                else if (limiteInferior <numero && limiteSuperior > numero)
                {
                    Console.WriteLine($"El número {numero} esta entre limite inferior y el limite superior");
                }
                else if (numero == limiteSuperior)
                {
                    Console.WriteLine($"El número {numero} esta en el limite superior");
                }
                else
                {
                    Console.WriteLine($"El número {numero} es mayor al limite superior");
                }
            }
            else
            {
                Console.WriteLine($"{strNumero} no es un número");
            }

            Console.ReadLine();
        }
    }
}