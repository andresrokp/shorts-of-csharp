using System;
using System.Collections.Generic;
using System.Text;

namespace JaiderPaso3
{
    class Ejecutor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nHello World!");    
            Console.WriteLine("------------------------------------------\nBienvenido a la solución del Paso 3 - UNAD\n");
            while (true)
            {
                Console.WriteLine("\n------\n---------\n------------\nMenú principal.\nEscoja el programa a ejecutar");
                Console.WriteLine("\ta) Calculador de Círculos");
                Console.WriteLine("\tb) Determinador de paridad");
                Console.WriteLine("\n>>Introduzca su elección (a/b). 's' para salir :");
                string reading = Console.ReadLine();
                if (reading == "a")
                {
                    CicloRadio MiCalculadorRadio = new CicloRadio();
                    MiCalculadorRadio.ejecutar();
                }
                else if (reading == "b")
                {
                    ParOimpar MiCalculadorRadio = new ParOimpar();
                    MiCalculadorRadio.ejecutar();
                }
                else if (reading == "s")
                {
                    Console.WriteLine("\n----------Ha salido. Hasta pronto!----------");
                    break;
                }
                else Console.WriteLine("\n>>Ingrese un valor válido<<");
            }
        }
    }
}

//Para J. Mengual por: andresrokp