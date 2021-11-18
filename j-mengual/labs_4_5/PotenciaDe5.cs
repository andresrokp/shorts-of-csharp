using System;
using System.Collections.Generic;
using System.Text;

namespace JaiderLabs_4_5
{
    class PotenciaDe5
    {
        private string reading = "";
        private int inNum = 0;
        private int count = 0;
        private int sum = 0;
        private int[] nums = new int[10];
        
        public void ejecutar()
        {
            while (true)
            {
                       
                Console.WriteLine("\n\n---------------------------------------------------------\nLABORATORIO PASO 3 - Ej22 - Bienvenido a la potencia de 5");
                Console.WriteLine("\n>>Ingrese 10 números enteros negativos: ");
                count = 0;
                while (count < 10)
                {
                    Console.WriteLine("\n>>Ingrese un número entero negativo ('s', para salir) : ");
                    Console.Write("\n>> #" + (count + 1) + " : ");
                    reading = Console.ReadLine();
                    if (int.TryParse(reading, out inNum) && inNum < 0)
                    {
                        nums[count] = inNum;
                        count++;
                        continue;
                    }
                    if (reading == "s") break;
                    Console.WriteLine("xx Ingrese un valor válido xx");
                }
                if (reading == "s") break;
                Console.WriteLine("\n\n¡Finalizado!.\n\nLa lista de las 10 potencias de 5 es : ");
                for(int i = 0 ; i < 10 ; i++)
                {
                    Console.WriteLine("#" + (i+1) + ") " + nums[i] + " --> " + nums[i] + "^5 = " + Math.Pow(nums[i], 5));
                }
                Console.WriteLine("\n\n...Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            Console.WriteLine("\n\n----------Ha salido. Hasta pronto!----------");
            Console.WriteLine("\n\n...Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}
