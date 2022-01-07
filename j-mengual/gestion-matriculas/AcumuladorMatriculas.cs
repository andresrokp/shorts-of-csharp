
using System;
using System.Collections.Generic;
using System.Text;

namespace JaiderPasoFinal
{
    class AcumuladorMatriculas
    {
        private int cantidadMatriculas = 0;
        private int totalCreditos = 0;
        private double valorTotalSinDescuento = 0;
        private double valorTotalNeto = 0;

        public AcumuladorMatriculas()
        {
        }

        public void agregarMatricula(Matricula unaMatricula)
        {
            this.cantidadMatriculas += 1;
            this.totalCreditos += unaMatricula.getPrograma().getNumeroCreditos();
            this.valorTotalSinDescuento += unaMatricula.getValorBase();
            this.valorTotalNeto += unaMatricula.calcularValorFinal();
        }

        public override string ToString()
        {
            return "\nCantidad total de estudiantes: "
                    + cantidadMatriculas
                    + "\nTotal de créditos inscritos: "
                    + totalCreditos
                    + "\nValor total pagafo antes de descuentos: "
                    + valorTotalSinDescuento
                    + "\nValor total de descuentos aplicados: "
                    + (valorTotalSinDescuento - valorTotalNeto)
                    + "\nValor neto de las inscripciones: "
                    + valorTotalNeto;
        }
    }
}
