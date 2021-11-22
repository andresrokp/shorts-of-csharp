using System;
using System.Collections.Generic;
using System.Text;

namespace Jaider_Paso_4
{
    class CreditosUNAD
    {
        private string reading = "";
        private float inNum = 0;
        private float numCreditos = 0;
        private float porcentaje = 0;
        
        const string opcA = "\n  -> Proyecto aplicado\n  -> Proyecto de investigación\n  -> Monografía";
        const string opcB = "\n  -> Diplomado de profundización\n  -> Créditos de posgrado";

        public void ejecutar()
        {
            while (true)
            {
                                       
                Console.WriteLine("\n\n-----------------------------------------------\nPASO 4 - Ej11 - Bienvenido al Ubicador de Grado");
                Console.WriteLine("\n>>Escoja su programa de estudio: ");
                Console.WriteLine("\ta) Ing. Sistemas");
                Console.WriteLine("\tb) Ing. Electrónica");
                Console.WriteLine("\tc) Ing. de Telecomunicaciones");
                Console.WriteLine("\td) Ing. Industrial");
                Console.WriteLine("\te) Ing. Multimedia");
                Console.Write("\n>>Introduzca su elección (a-e). 's' para salir : ");
                string reading = Console.ReadLine();
                switch (reading)
                {
                    case "a":
                        numCreditos = 149;
                        break;
                    case "b":
                        numCreditos = 170;
                        break;
                    case "c":
                        numCreditos = 158;
                        break;
                    case "d":
                        numCreditos = 160;
                        break;
                    case "e":
                        numCreditos = 152;
                        break;
                    case "s":
                        Console.WriteLine("\n----------Ha salido. Hasta pronto!----------");
                        break;
                    default:
                        Console.WriteLine("\nxx Ingrese un valor válido xx");
                        continue;
                }
                if (reading == "s") break;

                Console.Write(">>Ingrese su número de créditos aprobados ('s' para salir.) : ");
                reading = Console.ReadLine();
                if (reading == "s") break;

                if (float.TryParse(reading, out inNum) && 0 <= inNum && inNum <= numCreditos)
                {
                    porcentaje = inNum / numCreditos * 100;
                }
                else
                {
                    Console.WriteLine("xx Ingrese un valor válido xx");
                    continue;
                }

                if (reading == "s") break;
                Console.WriteLine("\n\n¡Finalizado!.\n\nSu porcentaje aprobado es : " + porcentaje);
                if (90 <= porcentaje) Console.WriteLine("\nOpciones:"+opcA+opcB);
                if (75 <= porcentaje && porcentaje < 90) Console.WriteLine("\nOpciones:" + opcB);
                if (porcentaje < 75) Console.WriteLine("\n -> Usted aún NO puede optar por una opción de grado");
                Console.WriteLine("\n\n...Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            Console.WriteLine("\n----------Ha salido. Hasta pronto!----------");
            Console.WriteLine("\n\n...Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}
