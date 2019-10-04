using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa08._20
{
    /// <summary>
    /// 20.  Que haga un menú del tipo “desea salir (S/N)” y el programa no termine hasta que el usuario teclee “S”.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = string.Empty;
            Console.WriteLine("20. Menú dummy");
            do
            {
                Console.Write("¿Desea salir? (S/N) ");
                opcion = Console.ReadLine();
               
                if (opcion.ToUpper() != "S")
                {
                    Console.WriteLine("Opción incorrecta");
                }
            } while (opcion.ToUpper() != "S");
        }//Main
    }//Program
}
