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
using System.Net;
using System.Data;

using System.Xml;
using System.Globalization;

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

        /// <summary>
        /// Listener for Promo service
        /// </summary>
        /// <returns>XMl response packet</returns>
        [WebInvoke(UriTemplate = "", Method = "POST", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare)]
        public XmlElement Create()
        {

            XmlDocument retxml = null;
            retxml = new XmlDocument();
            string xmlstring = OperationContext.Current.RequestContext.RequestMessage.ToString();
            retxml.LoadXml(@"<xml><returncode> 200</returncode></xml>");
            xml store = new xml();
            store.xml1 = xmlstring;
            try
            {
                Dictionary<string,string> sid = new Dictionary<string, string>();
                PoopDataDataContext poop = new PoopDataDataContext();
                poop.xmls.InsertOnSubmit(store);
                poop.SubmitChanges();
                ////Parse Packet into dataset
                DataSet retd = new DataSet();
                XmlDocument ret = new XmlDocument();
                ret.LoadXml(xmlstring);
                MemoryStream ms = new MemoryStream();
                ret.Save(ms);
                ms.Seek(0, 0);
                retd.ReadXml(ms, XmlReadMode.Auto);


                string strTimeStamp = DateTime.Now.ToString("s", CultureInfo.CreateSpecificCulture("en-US"));
                string retstr = @"<xml xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""
xsi:noNamespaceSchemaLocation=""0"">

</xml>";
                retxml = new XmlDocument();
                retxml.LoadXml(retstr);
                PoopDataDataContext Poop = new PoopDataDataContext();
                foreach (DataRow row in retd.Tables["Order"].Rows)
                {
                  
                    Cust_to_org custrec = (from c in poop.Cust_to_orgs
                                           where c.email.Trim().ToUpper() == row["email"].ToString().Trim().ToUpper()
                                           select c).FirstOrDefault();
 

                    OrderHeader head = new OrderHeader();
                    if (row.Table.Columns.Contains("advertising_source") && row["advertising_source"].ToString() != "")
                    {

                        var result = (poop.GetOrgID(row["advertising_source"].ToString()).FirstOrDefault());
                        if (result != null)
                        {
                            sid.Add(row["Order_Id"].ToString(), result.ORGID);
                            if (custrec != null)
                            {
                                custrec.OrgID = result.ORGID;
                            
                            }
                            else
                            {
                                custrec = new Cust_to_org();
                                custrec.email = row["email"].ToString();
                                custrec.FirstName = row["bill_to_first_name"].ToString();
                                custrec.Lastname = row["bill_to_last_name"].ToString();
                                custrec.OrgID = result.ORGID;
                                poop.Cust_to_orgs.InsertOnSubmit(custrec);
                            }
                        }


                        else if (custrec != null)
                        {
                            sid.Add(row["Order_Id"].ToString(), custrec.OrgID);

                        }
                    }
                    else if (custrec != null)
                    {
                        sid.Add(row["Order_Id"].ToString(), custrec.OrgID);

                    }
                    
                    head.OrderNumber = row["Order_Id"].ToString();
                    head.OrderDate = row["order_date"].ToString();
                    head.BillingAddr1 = row["bill_to_address1"].ToString();
                    head.BillingAddr2 = row["bill_to_address2"].ToString();
                    head.BillingFirstName = row["bill_to_first_name"].ToString();
                    head.BillingLastName = row["bill_to_last_name"].ToString();
                    head.City = row["bill_to_city"].ToString();
                    head.CompanyName = row["bill_to_company"].ToString();
                    head.CustomerID = row["merchant_id"].ToString();
                    if (row.Table.Columns.Contains("customer_ip_address"))
                    {
                        head.CustomerIPAddr = row["customer_ip_address"].ToString();
                    }
                    head.OrderComments = row["merchant_notes"].ToString();
                    head.OrderDate = row["order_date"].ToString();
                    head.OrderStatus = row["current_stage"].ToString();
                    head.PhoneNumber = row["day_phone"].ToString();
                    head.ShipCity = row["ship_to_city"].ToString();
                    head.ShipCompanyName = row["ship_to_company"].ToString();
                    head.ShipState = row["ship_to_state"].ToString();
                    head.ShipToAddr1 = row["ship_to_address1"].ToString();
                    head.ShipToAddr2 = row["ship_to_address2"].ToString();
                    head.ShipZipCode = row["ship_to_zip"].ToString();
                    head.State = row["bill_to_state"].ToString();
                    head.ZipCode = row["bill_to_zip"].ToString();
                    poop.OrderHeaders.InsertOnSubmit(head);
                }
                foreach (DataRow row in retd.Tables["item"].Rows)
                {
                    string orgid = "";
                    if (sid.ContainsKey(row["Order_Id"].ToString()))
                    {
                         sid.TryGetValue(row["Order_Id"].ToString(), out orgid);
                    }

                    OrderDetail detail = new OrderDetail();
                    detail.OrderNumber = row["Order_Id"].ToString();
                    detail.LineNumber = int.Parse(row["item_index"].ToString());
                    detail.OrgId = orgid;
                    detail.Price = row["cost"].ToString();
                    detail.ProductCode = row["accounting_code"].ToString();
                    detail.ProductName = row["description"].ToString();
                    detail.qty = int.Parse(row["quantity"].ToString());
                    poop.OrderDetails.InsertOnSubmit(detail);
                }
                poop.SubmitChanges();
            }
            catch (Exception e)
            {
                //Something went wrong
                retxml.LoadXml(@"<xml><returncode> "+e.Message+"</returncode></xml>");
                return retxml.DocumentElement     ;
            }
            return retxml.DocumentElement;
        }

       
    }
}
