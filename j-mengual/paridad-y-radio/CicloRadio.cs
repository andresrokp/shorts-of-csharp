using System;

namespace JaiderPaso3
{
    class CicloRadio
    {
        public void ejecutar()
        {
            string reading = "";
            int inNum = 0;
            double sumaAreas = 0;
            double sumaPerimetros = 0;                  
            Console.WriteLine("\n\n------------------------------------\nBienvenido al Calculador de Círculos");
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("\n>>Ingrese el valor (entero) del radio (s, para salir) : ");
                    reading = Console.ReadLine();
                    // LESSON LEARNT : check if a string is a number - https://www.arungudelli.com/tutorial/c-sharp/check-if-string-is-number/
                    if (int.TryParse(reading, out inNum))
                    {
                        double perimetro = 2*Math.PI * inNum;
                        double area = Math.PI * inNum * inNum;
                        Console.WriteLine("El perímetro es : " + perimetro);
                        Console.WriteLine("El área es : " + area);
                        if(inNum % 2 != 0)
                        {
                            Console.WriteLine(">El valor del radio es impar");
                            sumaAreas = sumaAreas + area;
                            sumaPerimetros = sumaPerimetros + perimetro;
                            Console.WriteLine(">La suma de perímetros impares es : " + sumaPerimetros);
                            Console.WriteLine(">La suma de áreas impares es : " + sumaAreas);
                        }
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
