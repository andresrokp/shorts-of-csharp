using System;

namespace JaiderLabs_4_5
{
    class Ejecutor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------\nBienvenido a la solución de Laboratorio - UNAD\n");
            while (true)
            {
                Console.WriteLine("\n\n---\n------\n---------\n------------\nMenú principal.\n------------------\nEscoja el programa a ejecutar");
                Console.WriteLine("\ta) LAB PASO 3 - Ej 4 - Sumador de 15 números");
                Console.WriteLine("\tb) LAB PASO 3 - Ej 22 - 10 potencias a la 5");
                Console.WriteLine("\tc) LAB PASO 4 - Ej 5 - Promedio de 3 notas");
                Console.WriteLine("\td) LAB PASO 4 - Ej 14 - Calculador IMC");
                Console.Write("\n>>Introduzca su elección (a,b,c,d). 's' para salir : ");
                string reading = Console.ReadLine();
                switch (reading)
                {
                    case "a":
                        Sumador15 MiSumadorDe15 = new Sumador15();
                        MiSumadorDe15.ejecutar();
                        break;
                    case "b":
                        PotenciaDe5 MiPotenciador5 = new PotenciaDe5();
                        MiPotenciador5.ejecutar();
                        break;
                    case "c":
                        PromedioNotas MiPromedio = new PromedioNotas();
                        MiPromedio.ejecutar();
                        break;
                    case "d":
                        CalculadorIMC MiIMC = new CalculadorIMC();
                        MiIMC.ejecutar();
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
