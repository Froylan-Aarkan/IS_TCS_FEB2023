using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosConvertidor
{
    internal class ServiciosClima : IServiciosClima
    {
        public double convertirCentigradosAFarenheit(int centigrados)
        {
            double gradosFarenheit = (centigrados * 1.8) + 32;
            return gradosFarenheit;
        }

        public double convertirFarenheitACentigrados(int farenheit)
        {
            double gradosCentigrados = (farenheit - 32) * 1.8;
            return gradosCentigrados;
        }
    }
}
