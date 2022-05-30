using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Navegador
    {
        private Cuenta cuentaActiva;
        private IDictionary<int, Cuenta> listaCuentas;

        public Navegador()
        {
            
        }
        public void navegarCuenta()
        {
            int seleccion = 0;
            do
            {
                Console.WriteLine("\n\n----------------------------------\n\nSeleccione una opción");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Retiros");
                Console.WriteLine("3. Transferencia");
                Console.WriteLine("3. Consultar puntos ViveColombia");
                Console.WriteLine("3. Canjear puntos ViveColombia");
                Console.WriteLine("9. Salir");
                seleccion = 0;
                
                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Su saldo es : " + cuentaActiva.getSaldo());
                        break;
                    case 2:
                        try
                        {
                            cuentaDestino = Convert.ToInt32(Console.ReadLine().Trim(' '));
                        }
                        catch
                        {
                            Console.WriteLine("inserte un valor válido");
                        }
                        
                        cuentaActiva.doTransfer();
                        break;
                    case 3:
                        cuentaActiva.getPuntosC();
                        break;
                    case 4:
                        cuentaActiva.canjearPuntosC();
                        break;
                    case 9:
                        Console.WriteLine("Muchas gracias");
                        break;
                    default:
                        break;
                }

            }
            while (seleccion != 9);
        }

        public void navegarGeneral()
        {
            int numCuenta = 0;
            do
            {
                Console.WriteLine("\n\n----------------------------------\n\nIngrese su número de cuenta");
                numCuenta = Convert.ToInt32(Console.ReadLine().Trim(' '));
            }
            while (true);
        }
    }
}
