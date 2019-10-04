using System;

namespace Problema2Divisor
{
    class Program
    {


        static void Main(string[] args)
        {
            #region Variables
            int numeroA = 0;
            int numeroB = 0;
            string strNumeroA = string.Empty;
            string strNumeroB = string.Empty;
            bool isNumeroA = false;
            bool isNumeroB = false;
            int moduloA = 0;
            int moduloB = 0;
            #endregion

            Console.WriteLine("Programa que indica si de dos número ingresados, uno es divisor del otro");
            Console.WriteLine();


            #region Lectura de datos
            Console.Write("ingrese un primer número: ");
            strNumeroA = Console.ReadLine();
            Console.Write("ingrese un segundo número: ");
            strNumeroB = Console.ReadLine();
            #endregion

            #region Conversion de datos
            isNumeroA = Int32.TryParse(strNumeroA, out numeroA);
            isNumeroB = Int32.TryParse(strNumeroB, out numeroB);
            #endregion

            //Evaluacion de datos
            if (isNumeroA && isNumeroB)
            {
                //Son números
                VerificacionDeDivisor(numeroA, numeroB);
            }
            else
            {
                //No son números alguno de los dos
                if (!isNumeroA)
                {
                    Console.WriteLine($"{strNumeroA} no es un número :(");
                }
                if (!isNumeroB)
                {
                    Console.WriteLine($"{strNumeroB} no es un número :(");
                }
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Verifica si uno es divisor del otro
        /// </summary>
        /// <param name="NumeroA"></param>
        /// <param name="NumeroB"></param>
        private static void VerificacionDeDivisor(int NumeroA, int NumeroB)
        {
            #region Variables
            int moduloA = 0;
            int moduloB = 0;
            #endregion

            if (NumeroB != 0)
                moduloA = NumeroA % NumeroB;
            else
                moduloA = 1;

            if (NumeroA != 0)
                moduloB = NumeroB % NumeroA;
            else
                moduloB = 1;

            if (moduloA == 0 || moduloB == 0)
            {
                if (moduloA == 0)
                {
                    Console.WriteLine($"{NumeroA} se puede dividir entre {NumeroB} de manera exacta");
                }
                else if (moduloB == 0)
                {
                    Console.WriteLine($"{NumeroB} se puede dividir entre {NumeroA} de manera exacta");
                }
            }
            else
            {
                Console.WriteLine("No hay división exacta :(");
            }
        }
    }
}