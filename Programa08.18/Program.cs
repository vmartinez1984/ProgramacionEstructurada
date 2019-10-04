using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._18
{
    /// <summary>
    /// 18.  Que escriba las tablas de multiplicar del 0 al 10.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            int length = 10;
            string cadena = string.Empty;
            string cadena2 = string.Empty;
            int i = 0;
            #endregion
            Console.WriteLine("18.- Programa que muestra las tablas de multiplicar");
            Console.WriteLine();

            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i.ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={(i * j).ToString().PadLeft(3, ' ').PadRight(4, ' ')}");
                Console.Write($"{(i + 1).ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={((i + 1) * j).ToString().PadLeft(3, ' ').PadRight(5, ' ')}");
                Console.Write($"{(i + 2).ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={((i + 2) * j).ToString().PadLeft(3, ' ').PadRight(5, ' ')}");
                Console.Write($"{(i + 3).ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={((i + 3) * j).ToString().PadLeft(3, ' ').PadRight(5, ' ')}");
                Console.Write($"{(i + 4).ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={((i + 4) * j).ToString().PadLeft(3, ' ').PadRight(5, ' ')}");
                Console.Write($"{(i + 5).ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={((i + 5) * j).ToString().PadLeft(3, ' ').PadRight(5, ' ')}");
                Console.WriteLine();
            }

            Console.WriteLine();
            i = 6;
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i.ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={(i * j).ToString().PadLeft(3, ' ').PadRight(4, ' ')}");
                Console.Write($"{(i + 1).ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={((i + 1) * j).ToString().PadLeft(3, ' ').PadRight(5, ' ')}");
                Console.Write($"{(i + 2).ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={((i + 2) * j).ToString().PadLeft(3, ' ').PadRight(5, ' ')}");
                Console.Write($"{(i + 3).ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={((i + 3) * j).ToString().PadLeft(3, ' ').PadRight(5, ' ')}");
                Console.Write($"{(i + 4).ToString().PadLeft(2, ' ')} X{j.ToString().PadLeft(2, ' ')} ={((i + 4) * j).ToString().PadLeft(3, ' ').PadRight(5, ' ')}");

                Console.WriteLine();
            }

            Console.ReadLine();
        }//Main
    }//Program
}//namespace
