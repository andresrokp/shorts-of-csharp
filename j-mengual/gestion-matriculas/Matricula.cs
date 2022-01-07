
using System;
using System.Collections.Generic;
using System.Text;

namespace JaiderPasoFinal
{
    class Matricula
    {
        private Programa programa;
        private double valorBase;
        private double factorDescuento = 0;
        private String tipoDescuento;

        public Matricula(String programa, String tipoDescuento)
        {
            this.programa = new Programa(programa);
            this.tipoDescuento = tipoDescuento;
            if (tipoDescuento == "efectivo") this.factorDescuento = this.programa.getDescuentoPrograma();
            this.valorBase = this.programa.getNumeroCreditos() * 200000;
        }
        
        public double getValorBase()
        {
            return valorBase;
        }

        public String getTipoDescuento()
        {
            return this.tipoDescuento;
        }

        public double getPorcentajeDescuento()
        {
            return this.factorDescuento * 100;
        }

        public Programa getPrograma()
        {
            return programa;
        }

        public double calcularValorFinal()
        {
            return Math.Floor(this.valorBase * (1 - this.factorDescuento));
        }


    }
}
