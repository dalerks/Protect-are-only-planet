using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Web;
using System.Collections;
using System.Xml;
using System.Data;
using System.Xml.Linq;

namespace Promo
{
    // Start the service and browse to http://<machine_name>:<port>/Service1/help to view the service's generated help page
    // NOTE: By default, a new instance of the service is created for each call; change the InstanceContextMode to Single if you want
    // a single instance of the service to process all calls.	
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    // NOTE: If the service is renamed, remember to update the global.asax.cs file
    public class Service1
    {
        // TODO: Implement the collection resource that will contain the SampleItem instances

 

        [WebInvoke(UriTemplate = "", Method = "POST", RequestFormat = WebMessageFormat.Xml, ResponseFormat=WebMessageFormat.Xml,BodyStyle=WebMessageBodyStyle.Bare)]
        public XElement Create()
        {
string messageid="";
         string test=   OperationContext.Current.RequestContext.RequestMessage.ToString();

         MemoryStream ms = new MemoryStream();
         XmlDocument request = new XmlDocument();
         request.LoadXml(test);
         request.Save(ms);
         ms.Seek(0, 0);
         DataSet data = new DataSet();
         data.ReadXml(ms,XmlReadMode.Auto);
         if (data.Tables.Contains("Header")){
             if(data.Tables["Header"].Columns.Contains("MessageId")){
          messageid = data.Tables["Header"].Rows[0]["MessageId"].ToString(); ;
         dataDataContext xmltable = new dataDataContext();
            Test_xml newxml = new Test_xml();

            newxml.Xml=test;
            xmltable.Test_xmls.InsertOnSubmit(newxml);
            xmltable.SubmitChanges();
             }
         }
            // TODO: Add the new instance of SampleItem to the collection


         XElement xmlTree1 =  XElement.Parse(@"<CRMAcresMessage xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:noNamespaceSchemaLocation=""0"">
<Header>
    <OriginalMessageID>"+messageid+@"</OriginalMessageID>
    <TimeStamp>"+DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ssZ")+@"</TimeStamp>
    <Operation Data=""General"" Operand=""Success""/>
  </Header>
</CRMAcresMessage>
");
            return xmlTree1;
        }

       
    }
}
