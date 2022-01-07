
using System;
using System.Collections.Generic;
using System.Text;

namespace JaiderPasoFinal
{
    class Programa
    {
        private String nombrePrograma;
        private int numeroCreditos;
        private double descuentoPrograma;

        public Programa(string nombrePrograma)
        {
            switch (nombrePrograma)
            {
                case "Ingenieria de Sistemas":
                    this.nombrePrograma = nombrePrograma;
                    numeroCreditos = 20;
                    descuentoPrograma = 0.18;
                    break;
                case "Psicologia":
                    this.nombrePrograma = nombrePrograma;
                    numeroCreditos = 16;
                    descuentoPrograma = 0.12;
                    break;
                case "Economia":
                    this.nombrePrograma = nombrePrograma;
                    numeroCreditos = 18;
                    descuentoPrograma = 0.1;
                    break;
                case "Comunicacion Social":
                    this.nombrePrograma = nombrePrograma;
                    numeroCreditos = 18;
                    descuentoPrograma = 0.05;
                    break;
                case "Administracion de Empresa":
                    this.nombrePrograma = nombrePrograma;
                    numeroCreditos = 20;
                    descuentoPrograma = 0.15;
                    break;
            }
        }
                
        public String getNombrePrograma()
        {
            return this.nombrePrograma;
        }
        public double getDescuentoPrograma()
        {
            return this.descuentoPrograma;
        }

        public int getNumeroCreditos()
        {
            return numeroCreditos;
        }

    }
}
