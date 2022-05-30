using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Cuenta
    {
        public int id;
        public string password;
        public int puntosC;
        public int saldo;

        public Cuenta(int id, string password, int puntosC, int saldo)
        {
            this.id = id;
            this.password = password;
            this.puntosC = puntosC;
            this.saldo = saldo;
        }

        public int getSaldo()
        {
            return saldo;
        }

        internal void doTransfer(Cuenta cuentaDestino)
        {
            throw new NotImplementedException();
        }
    }
}
