using System;
using System.Collections.Generic;
using System.Text;

namespace JaiderLabs_4_5
{
    class CalculadorIMC
    {
        private string readingAltura = "";
        private string readingPeso = "";
        private float inNumAltura = 0;
        private float inNumPeso = 0;
        private double IMC = 0;
        
        public void ejecutar()
        {
            
            while (true)
            {
                Console.WriteLine("\n\n-----------------------------------------------------------\nLABORATORIO PASO 4 - Ej14 - Bienvenido al Calculador de IMC");
                Console.WriteLine("\n>>Ingrese la información: ");
                
                Console.Write("\n>>Ingrese su estatura en metros ('s' para salir. Use la COMA decimal) : ");
                readingAltura = Console.ReadLine();
                if (readingAltura == "s") break;
                Console.Write(">>Ingrese su peso en kilogramos ('s' para salir. Use la COMA decimal) : ");
                readingPeso = Console.ReadLine();
                if (readingPeso == "s") break;

                if (float.TryParse(readingAltura, out inNumAltura) && float.TryParse(readingPeso, out inNumPeso) 
                    && 0.3 <= inNumAltura && inNumAltura <= 2.5 && 2 < inNumPeso && inNumPeso < 200)
                {
                    IMC = inNumPeso / Math.Pow(inNumAltura, 2);
                }
                else
                {
                    Console.WriteLine("readingAltura : " + readingAltura);
                    Console.WriteLine("readingPeso : " + readingPeso); 
                    Console.WriteLine("inNumAltura : "+inNumAltura);
                    Console.WriteLine("inNumPeso : " + inNumPeso);
                    Console.WriteLine("xx Ingrese un valor válido xx");
                    continue;
                }

                Console.Write("\n\n¡Finalizado!.\n\nSu IMC es : " + IMC);
                if (30 < IMC) Console.WriteLine(" -> Obesidad");
                if (25 <= IMC && IMC < 29.9) Console.WriteLine(" -> Peso superior al normal");
                if (18.5 <= IMC && IMC < 24.9) Console.WriteLine(" -> Normal");
                if (IMC < 18.5) Console.WriteLine(" -> Peso Inferior al Normal");
                
                Console.WriteLine("\n\n...Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            Console.WriteLine("\n\n----------Ha salido. Hasta pronto!----------");
            Console.WriteLine("\n\n...Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
