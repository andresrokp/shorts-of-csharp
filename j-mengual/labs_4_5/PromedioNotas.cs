using System;
using System.Collections.Generic;
using System.Text;

namespace JaiderLabs_4_5
{
    class PromedioNotas
    {
        private string reading = "";
        private float inNum = 0;
        private int count;
        private float prom = 0;
        
        public void ejecutar()
        {
            while (true)
            {
                Console.WriteLine("\n\n------------------------------------------------------------\nLABORATORIO PASO 4 - Ej5 - Bienvenido al Promedio de 3 notas");
                Console.WriteLine("\n>>Ingrese 3 valores de notas entre 0 y 5: ");
                prom = 0;
                count = 0;
                while (count < 3)
                {
                    Console.WriteLine("\n>>Ingrese el valor de la nota ('s', para salir) : ");
                    Console.Write("\n>> #" + (count + 1) + " : ");
                    reading = Console.ReadLine();
                    if (float.TryParse(reading, out inNum) && 0 <= inNum && inNum <= 5)
                    {
                        prom += inNum/3;
                        count++;
                        continue;
                    }
                    if (reading == "s") break;
                    Console.WriteLine("xx Ingrese un valor válido xx");
                }
                if (reading == "s")
                {
                    break;
                }
                Console.Write("\n\n¡Finalizado!.  El promedio de los 3 valores es : "+prom);
                if (4.6 <= prom) Console.WriteLine(" -> Excelente");
                if (4.0 <= prom && prom <= 4.5) Console.WriteLine(" -> Muy Bueno");
                if (3.5 <= prom && prom < 4.0) Console.WriteLine(" -> Bueno");
                if (3.0 <= prom && prom < 3.5) Console.WriteLine(" -> Satisfactorio");
                if (prom < 3.0) Console.WriteLine(" -> Deficiente");
                Console.WriteLine("\n\n...Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            Console.WriteLine("\n----------Ha salido. Hasta pronto!----------");
            Console.WriteLine("\n\n...Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}
