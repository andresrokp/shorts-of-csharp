using System;
using System.Collections.Generic;
using System.Text;

namespace JaiderPaso3
{
    class ParOimpar
    {
        public void ejecutar()
        {
            string reading = "";
            int inNum = 0;
            Console.WriteLine("\n\n----------------------------------\nBienvenido al Evaluador de Paridad");
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("\n>>Ingrese un número entero ('s', para salir) : ");
                    reading = Console.ReadLine();
                    // LESSON LEARNT : check if a string is a number - https://www.arungudelli.com/tutorial/c-sharp/check-if-string-is-number/
                    if (int.TryParse(reading, out inNum))
                    {
                        if (inNum % 2 == 0)
                        {
                            Console.WriteLine("El valor es PAR");
                        }
                        else
                        {
                            Console.WriteLine("El valor es IMPAR");
                        }
                        Console.WriteLine("El cuadrado del valor es : " + inNum*inNum);
                        Console.WriteLine("El cubo del valor es : " + inNum * inNum*inNum);
                        break;
                    }
                    if (reading == "s") break;
                    Console.WriteLine("\n>>Ingrese un valor válido<<");
                }
                if (reading == "s")
                {
                    Console.WriteLine("\n----------Ha salido. Hasta pronto!----------");
                    break;
                }
            }
        }
    }
}

//Para J. Mengual por: andresrokp