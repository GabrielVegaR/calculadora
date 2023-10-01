using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Calculadora
    {
        public double Suma(double numero1, double numero2)
        {
            double suma = numero1 + numero2;

            return suma;
        }

        public double Resta(double numero1, double numero2)
        {
            double resta = numero1 - numero2;

            return resta;
        }

        public double Multiplicacion(double numero1, double numero2)
        {
            double multiplicacion = numero1 * numero2;

            return multiplicacion;
        }

        public double Division(double numero1, double numero2)
        {
            double division = numero1 / numero2;

            return division;
        }
    }
}
