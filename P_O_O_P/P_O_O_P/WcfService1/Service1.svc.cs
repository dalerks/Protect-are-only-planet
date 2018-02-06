using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string GetData(Guid value)
        {
            try
            {
         PoopStatsDataContext poop = new PoopStatsDataContext();
                try
                {
                    POOPDATA.Get_Orders();
                }
                catch (Exception e)
                {
                    poop.AddError(e.Message);

                }
                int dropid = 0;
                string xml = "";
       
                var drop = poop.GetDropId(value);
                foreach (var r in drop)
                {
                    dropid = r.Dropshipid;
                }
                var result = poop.GetXmlOrders(dropid);

                foreach (var r in result)
                {
                    xml += r.XML_F52E2B61_18A1_11d1_B105_00805F49916B;
                }
                return string.Format(xml);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public void Update()
        {
            POOPDATA.Get_Orders();
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
