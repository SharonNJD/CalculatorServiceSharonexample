using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorServiceSharon
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Sum(double x,double Y);
        [OperationContract]
        double Sub(double x, double Y);
        [OperationContract]
        double Mul(double x, double Y);
        [OperationContract]
        double Div(double x, double Y);
    }
}
