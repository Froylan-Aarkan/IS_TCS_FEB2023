using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosConvertidor
{
    [ServiceContract]
    internal interface IServiciosClima
    {
        [OperationContract]
        double convertirCentigradosAFarenheit(int centigrados);
        
        [OperationContract]
        double convertirFarenheitACentigrados(int farenheit);
    }
}
