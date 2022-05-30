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
            this.listaCuentas = new Dictionary<int, Cuenta>();
            Cuenta c1 = new Cuenta(100, "pass1", 10000, 1000000);
            Cuenta c2 = new Cuenta(200, "pass2", 20000, 2000000);
            Cuenta c3 = new Cuenta(300, "pass3", 30000, 3000000);
            Cuenta c4 = new Cuenta(400, "pass4", 40000, 4000000);
            Cuenta c5 = new Cuenta(500, "pass5", 50000, 5000000);
            listaCuentas[c1.id] = c1;
            listaCuentas[c2.id] = c2;
            listaCuentas[c3.id] = c3;
            listaCuentas[c4.id] = c4;
            listaCuentas[c5.id] = c5;

        }

        private void retirarDinero()
        {
            cuentaActiva.retirarDinero();
        }
        private void transferirDinero()
        {
            try
            {
                Console.WriteLine("Inserte el número de cuenta destino");
                int numCuentaDestino = Convert.ToInt32(Console.ReadLine().Trim(' '));
                try
                {
                    Cuenta cuentaDestino = listaCuentas[numCuentaDestino];
                    Console.WriteLine("Inserte el valor a transferir");
                    int valorTransf = Convert.ToInt32(Console.ReadLine().Trim(' '));
                    if (cuentaActiva.saldo > valorTransf) cuentaActiva.doTransfer(cuentaDestino, valorTransf);
                    else Console.WriteLine("saldo insuficiente");
                }
                catch { Console.WriteLine("Cuenta no válida"); }
            }
            catch
            {
                Console.WriteLine("inserte un valor válido");
            }
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
                Console.WriteLine("4. Consultar puntos ViveColombia");
                Console.WriteLine("5. Canjear puntos ViveColombia");
                Console.WriteLine("9. Salir");
                seleccion = Convert.ToInt32(Console.ReadLine().Trim(' '));
                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Su saldo es : " + cuentaActiva.getSaldo());
                        break;
                    case 2:
                        retirarDinero();
                        break;
                    case 3:
                        transferirDinero();
                        break;
                    case 4:
                        Console.WriteLine("Su saldo es : " + cuentaActiva.puntosC);
                        break;
                    case 5:
                        // cuentaActiva.canjearPuntosC();
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
                Console.WriteLine("Ingrese contraseña");
                string pass = Console.ReadLine();
                try
                {
                    if (listaCuentas[numCuenta].password == pass)
                    {
                        cuentaActiva = listaCuentas[numCuenta];
                        navegarCuenta();
                    }
                    else Console.WriteLine("Valores inválidos");
                }
                catch
                {
                    Console.WriteLine("Valores inválidos");
                }
            }
            while (true);
        }
    }
}
