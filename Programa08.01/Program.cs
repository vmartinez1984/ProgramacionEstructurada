﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int numero = 0;
            int contador = 0;
            int i;

            #endregion

            Console.WriteLine("Programa que indica si el número ingresado es primo");
            Console.Write("Introduzaca un número ");
            numero = LeerNumero();

            for (i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }

            if(contador == 2 || contador == 1 || contador == 0)
            {
                Console.WriteLine("El número es primo");
            }
            else
            {
                Console.WriteLine("El número no es primo");
            }

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
        }//LeerNumero
    }
}
