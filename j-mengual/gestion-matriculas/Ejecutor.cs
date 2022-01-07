
using System;

namespace JaiderPasoFinal
{
    class Ejecutor
    {
        private void imprimirMenuPrograma()
        {
            Console.WriteLine("\n\nEscoja el programa académico: ");
            Console.WriteLine("\ta) Ingeniería de sistemas");
            Console.WriteLine("\tb) Psicología");
            Console.WriteLine("\tc) Economía");
            Console.WriteLine("\td) Comunicación Social");
            Console.WriteLine("\te) Administración de Empresas");
            Console.Write("\n>>Introduzca su elección (a,b,c,d,e). 's' para salir : ");
        }
        private String elegirPrograma(String reading)
        {
            switch (reading)
            {
                case "a":
                    return "Ingenieria de Sistemas";
                case "b":
                    return "Psicologia";
                case "c":
                    return "Economia";
                case "d":
                    return "Comunicacion Social";
                case "e":
                    return "Administracion de Empresa";
                case "s":
                    return "Salir";
                default:
                    return "Malo";
            }
        }
        private void imprimirMenuPago()
        {
            Console.WriteLine("\n\nEscoja el tipo de Pago: ");
            Console.WriteLine("\ta) Efectivo");
            Console.WriteLine("\tb) En línea");
            Console.Write("\n>>Introduzca su elección (a,b). 's' para salir : ");

        }
        private String definirDescuento(String reading)
        {
            switch (reading)
            {
                case "a":
                    return "efectivo";
                case "b":
                    return "enLinea";
                case "s":
                    return "salir";
                default:
                    return "nada";
            }
        }
        public void imprimirDatos(Matricula thisMatricula)
        {
            Console.WriteLine("\n\nPrograma: "
                                     + thisMatricula.getPrograma().getNombrePrograma()
                                     + "\nNúmero de créditos:"
                                     + thisMatricula.getPrograma().getNumeroCreditos()
                                     + "\nValor base: "
                                     + thisMatricula.getValorBase()
                                     + "\nTipo de pago: "
                                     + thisMatricula.getTipoDescuento()
                                     + "\nDescuento: "
                                     + thisMatricula.getPorcentajeDescuento() + "%"
                                     + "\nValor luego de descuento: "
                                     + thisMatricula.calcularValorFinal());
        }
        static void Main(string[] args)
        {
            Ejecutor runner = new Ejecutor();
            AcumuladorMatriculas miAcumulador = new AcumuladorMatriculas();
            Console.WriteLine("----------------------------------------------\nBienvenido a la solución del Paso Final - UNAD\n");
            while (true)
            {
                runner.imprimirMenuPrograma();
                string reading = Console.ReadLine();
                String programaElegido = runner.elegirPrograma(reading);
                if (programaElegido == "Malo")
                {
                    Console.WriteLine("\n>>Ingrese un valor válido<<");
                    continue;
                }
                if (programaElegido == "Salir") break;
                Console.WriteLine(">  >Ha seleccionado: " + programaElegido);

                runner.imprimirMenuPago();
                reading = Console.ReadLine();
                String descuento = runner.definirDescuento(reading);
                if (descuento == "nada")
                {
                    Console.WriteLine("\n>>Ingrese un valor válido<<");
                    continue;
                }
                if (descuento == "salir") break;
                Console.WriteLine(">  >Ha seleccionado: " + descuento);

                Matricula thisMatricula = new Matricula(programaElegido, descuento);

                runner.imprimirDatos(thisMatricula);
                                
                miAcumulador.agregarMatricula(thisMatricula);
            }
            Console.WriteLine("\n----------Ha salido. Hasta pronto!----------");
            Console.WriteLine("\nResultado acumulado del proceso: ");
            Console.WriteLine(miAcumulador);
            Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

// Para J. Mengual - Por: andresrokp
