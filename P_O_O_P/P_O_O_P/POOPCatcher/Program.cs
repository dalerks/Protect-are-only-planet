using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace POOPCatcher
{
    class Program
    {
        static void Main(string[] args)
        {
        
            poopie.Service1Client poop = new poopie.Service1Client();
                 Guid g = Guid.Parse("2B71BF30-382E-450A-9BE8-5A245E6BF4F1");
            string xmlstring =poop.GetData(g);
            XmlDocument APIDoc = new XmlDocument();
            APIDoc.LoadXml(xmlstring);
            APIDoc.Save("Poop.xml");
        }
    }
}
