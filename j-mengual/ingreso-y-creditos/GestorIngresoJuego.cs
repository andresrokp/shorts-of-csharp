using System;
using System.Collections.Generic;
using System.Text;

namespace Jaider_Paso_4
{
    class GestorIngresoJuego
    {
        private string readingAltura = "";
        private string readingPeso = "";
        private string readingGenero = "";
        private float inNumAltura = 0;
        private float inNumPeso = 0;
        
        public void ejecutar()
        {

            while (true)
            {
                Console.WriteLine("\n\n----------------------------------------------------------\nPASO 4 - Ej12 - Bienvenido al Gestor de Ingreso del parque");
                Console.WriteLine("\nIngrese la información solicitada. Use la COMA decimal.");

                Console.Write("\n>>Ingrese su estatura en metros ('s' para salir.) : ");
                readingAltura = Console.ReadLine();
                if (readingAltura == "s") break;
                Console.Write(">>Ingrese su peso en kilogramos ('s' para salir.) : ");
                readingPeso = Console.ReadLine();
                if (readingPeso == "s") break;
                Console.Write(">>Ingrese su género ( 'f' / 'm' ; 's' para salir ) : ");
                readingGenero = Console.ReadLine();
                if (readingPeso == "s") break;

                if ( !(float.TryParse(readingAltura, out inNumAltura)
                        && float.TryParse(readingPeso, out inNumPeso)
                        && (readingGenero != "f" || readingGenero != "m")
                        && 0.6 <= inNumAltura && inNumAltura <= 2.5
                        && 2 < inNumPeso && inNumPeso < 200) )
                {
                    Console.WriteLine("xx Ingrese valores válidos xx");
                    continue;
                }

                Console.WriteLine("\n>>Escoja el Juego: ");
                Console.WriteLine("\ta) Carros chocones");
                Console.WriteLine("\tb) Licuadora");
                Console.WriteLine("\tc) El pulpo");
                Console.WriteLine("\td) Montaña rusa");
                Console.Write("\n>>Introduzca su elección (a-d). 's' para salir : ");
                string reading = Console.ReadLine();
                Console.WriteLine(" ");
                switch (reading)
                {
                    case "a":
                        if (1.2 < inNumAltura && 60 < inNumPeso && readingGenero == "f") Console.WriteLine("> Puede ingresar a los Carros chocones");
                        else Console.WriteLine("> NO puede ingresar a los Carros chocones");
                        break;
                    case "b":
                        if (1.4 < inNumAltura && 65 < inNumPeso && readingGenero == "m") Console.WriteLine("> Puede ingresar a la licuadora");
                        else Console.WriteLine("> NO puede ingresar a la licuadora");
                        break;
                    case "c":
                        if (1.6 < inNumAltura && 70 < inNumPeso && readingGenero == "f") Console.WriteLine("> Puede ingresar al pulpo");
                        else Console.WriteLine("> NO puede ingresar al pulpo");
                        break;
                    case "d":
                        if (1.8 < inNumAltura && 80 < inNumPeso && readingGenero == "m") Console.WriteLine("> Puede ingresar a la montaña rusa");
                        else Console.WriteLine("> NO puede ingresar a la montaña rusa");
                        break;
                    case "s":
                        Console.WriteLine("\n----------Ha salido. Hasta pronto!----------");
                        break;
                    default:
                        Console.WriteLine("\n>>Ingrese un valor válido<<");
                        continue;
                }
                if (reading == "s") break;

                Console.WriteLine("\n\n...Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            Console.WriteLine("\n\n----------Ha salido. Hasta pronto!----------");
            Console.WriteLine("\n\n...Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
