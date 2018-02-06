using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.IService1 test = new ServiceReference1.Service1Client();
            Guid g = Guid.Parse("2B71BF30-382E-450A-9BE8-5A245E6BF4F1");
           // test.Update();
           string te =test.GetData(g);
            
        }
    }
}
