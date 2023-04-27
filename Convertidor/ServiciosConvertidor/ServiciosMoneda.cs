using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosConvertidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServiciosMoneda : IServiciosMoneda
    {
        public double convertirDolarAPeso(int dolares)
        {
            double pesos = dolares * 20;
            return pesos;
        }

        public double convertirPesoADolar(int pesos)
        {
            double dolares = pesos / 20;
            return dolares;
        }
    }
}
