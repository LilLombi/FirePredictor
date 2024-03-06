using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirePredictor
{
    public class MathOperations
    {
        public static double chandlerBI(double temperatura, double humedadRelativa)
        {
            // Validar entrada
            if (temperatura < -50 || temperatura > 50)
            {
                throw new ArgumentOutOfRangeException("La temperatura debe estar entre -50 y 50 °C");
            }

            if (humedadRelativa < -100 || humedadRelativa > 100)
            {
                throw new ArgumentOutOfRangeException("La humedad relativa debe estar entre 0 y 100 %");
            }

            humedadRelativa = Math.Abs(humedadRelativa);

            // Cálculo del CBI
            double cbi = (((110 - 1.373 * humedadRelativa) - 0.54 * (10.20 - temperatura)) * (124 * Math.Pow(10, -0.0142 * humedadRelativa))) / 60;
            if (cbi < 0)
            {
                cbi = 0;
            }
            return Math.Round(cbi);
        }
    }
}
