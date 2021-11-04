using System;
using System.Collections;

namespace Project2
{
    class DatosTemperatura
    {
        static void Main(string[] args)
        {
            int maxNum = 7;
            while (true)
            {
                float maxTemp = -1000;
                float minTemp = 9999;
                float prom = 0;
                ArrayList registros = new ArrayList();
                Console.WriteLine("---------------------\nBienvenido!\n");
                Console.WriteLine("Ingrese los valores usando la coma (,) para decimales\n\n");
                for (int i = 1; i <= maxNum; i++)
                {
                    Console.WriteLine("Registro: " + (i));
                    float temp = float.Parse(Console.ReadLine());
                    prom += (temp / maxNum);
                    if (temp > maxTemp) maxTemp = temp;
                    if (temp < minTemp) minTemp = temp;
                    registros.Add(temp);
                }

                Console.WriteLine("\nLos registros realizados fueron : \n");
                foreach (var reg in registros) Console.WriteLine("\t> " + reg);
                Console.WriteLine("Temperatura más alta : " + maxTemp);
                Console.WriteLine("Temperatura más baja : " + minTemp);
                Console.WriteLine("Promedio de Temperaturas : " + prom);

                string ans = "s";
                while (true)
                {
                    Console.WriteLine("\n\n¿Desea continuar? (s/n):");
                    ans = Console.ReadLine();
                    if (ans == "s" || ans == "n") break;
                }
                if (ans == "n") break;
            }
        }
    }
}

//Para J. Mengual - Por: andresrokp