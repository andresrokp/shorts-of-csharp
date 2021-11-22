using System;

namespace Jaider_Paso_4
{
    class Ejecutor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------\nBienvenido a la solución del PASO 4 - UNAD\n");
            while (true)
            {
                Console.WriteLine("\n\n---\n------\n---------\n------------\nMenú principal.\n------------------\nEscoja el programa a ejecutar");
                Console.WriteLine("\ta) Ubicador de grado UNAD");
                Console.WriteLine("\tb) Gestor de ingreso a Juego");
                Console.Write("\n>>Introduzca su elección (a,b). 's' para salir : ");
                string reading = Console.ReadLine();
                switch (reading)
                {
                    case "a":
                        CreditosUNAD MiCalcCred = new CreditosUNAD();
                        MiCalcCred.ejecutar();
                        break;
                    case "b":
                        GestorIngresoJuego MiGestor = new GestorIngresoJuego();
                        MiGestor.ejecutar();
                        break;
                    case "s":
                        Console.WriteLine("\n----------Ha salido. Hasta pronto!----------");
                        break;
                    default:
                        Console.WriteLine("\n>>Ingrese un valor válido<<");
                        break;
                }
                if (reading == "s") break;
            }
        }
    }
}
