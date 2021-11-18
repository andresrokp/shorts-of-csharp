using System;
using System.Collections.Generic;
using System.Text;

namespace JaiderLabs_4_5
{
    class Sumador15
    {
        private string reading = "";
        private int inNum = 0;
        private int count = 0;
        private int sum = 0;
        
        public void ejecutar()
        {
            while (true)
            {
            Console.WriteLine("\n\n--------------------------------------------------------\nLABORATORIO PASO 3 - Bienvenido al Sumador de 15 números");
            Console.WriteLine("\n>>Ingrese 15 números entre 50 y 500: ");
                count = 0;
                sum = 0;
                while (count < 15)
                {
                    Console.WriteLine("\n>>Ingrese un número entre 50 y 500 ('s', para salir) : ");
                    Console.Write("\n>> #"+(count+1)+" : ");
                    reading = Console.ReadLine();
                    if (int.TryParse(reading, out inNum) && 50 < inNum && inNum < 500)
                    {
                        sum += inNum;
                        count++;
                        continue;
                    }
                    if (reading == "s") break;
                    Console.WriteLine("xx Ingrese un valor válido xx");
                }

                if (reading == "s") break;
                
                Console.WriteLine("\n\n¡Finalizado!.\nR/ La suma de los 15 valores es : "+sum);
                Console.WriteLine("\n\n...Presione cualquier tecla para continuar.");
                Console.ReadKey();
            }
            Console.WriteLine("\n\n----------Ha salido. Hasta pronto!----------");
            Console.WriteLine("\n\n...Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}
