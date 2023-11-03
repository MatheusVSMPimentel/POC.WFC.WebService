using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Services;


namespace POC.WFC.WebService
{
    public class MyWebService : IMyWebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello, World!";
        }

        [WebMethod]
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}