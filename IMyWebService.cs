using System;
using System.ServiceModel;

namespace POC.WFC.WebService
{
    [ServiceContract(Namespace = "http://localhost:8000/GettingStarted/MyWebService")]
    public interface IMyWebService
    {
        [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        string HelloWorld();
    }
}