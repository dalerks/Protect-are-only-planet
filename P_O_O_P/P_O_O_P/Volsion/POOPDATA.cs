using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;
using System.Data;
using System.Configuration;

namespace Volsion
{
    public static class POOPDATA
    {
        static public void Get_Orders()
        {
            PoopStatsDataContext poop = new PoopStatsDataContext(ConfigurationManager.ConnectionStrings["poopstatsConnectionString"].ConnectionString);
         
            DataSet data = Get_Data(@"http://ukgnr.sauet.servertrust.com/net/WebService.aspx?Login=orders@medallionenterprises.com&EncryptedPassword=C5339B97DED579FEABCC2018A09E5F55361EA83483C5A31203762D4602EE9E6A&EDI_Name=Generic\Orders&SELECT_Columns=*");
            if (data.Tables.Count > 0)
            {
                foreach (DataRow row in data.Tables[0].Rows)
                {

                    string subid = "";
                    if (row.Table.Columns.Contains("custom_field_spid")){
                    if (row["custom_field_spid"] != null && row["custom_field_spid"].ToString() != "")
                    {
                        subid = row["custom_field_spid"].ToString().ToUpper();
                    }
                    }
                
                    else if (row["Custom_Field_OurGiftingOrg"] != null && row["Custom_Field_OurGiftingOrg"].ToString() != "")
                    {
                        subid = row["Custom_Field_OurGiftingOrg"].ToString().ToUpper();
                    }
                    else
                    {
                        subid = "DEFAULT";
                    }

                    decimal Affiliate_Commissionable_Value = 0;
                    int CC_Last4 = 0;
                    int CheckNumber = 0;
                    DateTime CreditCardExpDate = DateTime.Now;
                    DateTime CreditCardIssueDate = DateTime.Now;
                    int CustomerID = 0;
                    DateTime OrderDate = DateTime.Now;
                    decimal PaymentAmount = 0;
                    int PaymentMethodID = 0;
                    decimal SalesTax1 = 0;
                    decimal SalesTax2 = 0;
                    decimal SalesTax3 = 0;
                    int SalesTaxRate = 0;
                    int SalesTaxRate1 = 0;
                    int SalesTaxRate2 = 0;
                    int SalesTaxRate3 = 0;
                    decimal Total_Payment_Authorized = 0;
                    decimal Total_Payment_Received = 0;
                    decimal TotalShippingCost = 0;
                    int VendorID = 0;
                    DateTime test = DateTime.Now.AddYears(-100);
                    string test2 = row["ShipPostalCode"].ToString();
                    decimal.TryParse(row["Affiliate_Commissionable_Value"].ToString(), out  Affiliate_Commissionable_Value);
                    int.TryParse(row["CC_Last4"].ToString(), out CC_Last4);
                    int.TryParse(row["CheckNumber"].ToString(), out CheckNumber);
                    DateTime.TryParse(row["CreditCardExpDate"].ToString(), out CreditCardExpDate);
                    if (CreditCardExpDate < test) { CreditCardExpDate = test; }
                    DateTime.TryParse(row["CreditCardIssueDate"].ToString(), out CreditCardIssueDate);
                    if (CreditCardIssueDate < test) { CreditCardIssueDate = test; }
                    int.TryParse(row["CustomerID"].ToString(), out CustomerID);
                    DateTime.TryParse(row["OrderDate"].ToString(), out OrderDate);
                    if (OrderDate < test) { OrderDate = test; }
                    decimal.TryParse(row["PaymentAmount"].ToString(), out PaymentAmount);
                    int.TryParse(row["PaymentMethodID"].ToString(), out PaymentMethodID);
                    decimal.TryParse(row["SalesTax1"].ToString(), out SalesTax1);
                    decimal.TryParse(row["SalesTax2"].ToString(), out SalesTax2);
                    decimal.TryParse(row["SalesTax3"].ToString(), out SalesTax3);
                    int.TryParse(row["SalesTaxRate"].ToString(), out SalesTaxRate);
                    int.TryParse(row["SalesTaxRate1"].ToString(), out SalesTaxRate1);
                    int.TryParse(row["SalesTaxRate2"].ToString(), out SalesTaxRate2);
                    int.TryParse(row["SalesTaxRate3"].ToString(), out SalesTaxRate3);
                    decimal.TryParse(row["Total_Payment_Authorized"].ToString(), out Total_Payment_Authorized);
                    decimal.TryParse(row["Total_Payment_Received"].ToString(), out Total_Payment_Received);
                    decimal.TryParse(row["TotalShippingCost"].ToString(), out TotalShippingCost);
                    int.TryParse(row["VendorID"].ToString(), out VendorID);
                    try
                    {
                        poop.UpdateorInsertOrders(int.Parse(row["OrderID"].ToString()),
                      row["AccountNumber"].ToString(),
                      row["AccountType"].ToString(),
                      (row["AddressValidated"].ToString().ToCharArray())[0],
                      Affiliate_Commissionable_Value,
                      row["AuthHash"].ToString(),
                      row["BankName"].ToString(),
                      row["BillingAddress1"].ToString(),
                      row["BillingAddress2"].ToString(),
                      row["BillingCity"].ToString(),
                      row["BillingCompanyName"].ToString(),
                      row["BillingCountry"].ToString(),
                      row["BillingFaxNumber"].ToString(),
                      row["BillingFirstName"].ToString(),
                      row["BillingLastName"].ToString(),
                      row["BillingPhoneNumber"].ToString(),
                      row["BillingPostalCode"].ToString(),
                      row["BillingState"].ToString(),
                      row["CardHoldersName"].ToString(),
                      CC_Last4,
                      CheckNumber,
                      CreditCardExpDate,
                      CreditCardIssueDate,
                      row["CreditCardIssueNumber"].ToString(),
                      row["Customer_IPAddress"].ToString(),
                      CustomerID,
                      (row["IsAGift"].ToString().ToCharArray())[0],
                      (row["Locked"].ToString().ToCharArray())[0],
                      row["MICR"].ToString(),
                      row["Order_Comments"].ToString(),
                      row["Order_Entry_System"].ToString(),
                      OrderDate,
                      row["OrderStatus"].ToString(),
                      PaymentAmount,
                      PaymentMethodID,
                      row["PONum"].ToString(),
                      row["RoutingNumber"].ToString(),
                      SalesTax1,
                      SalesTax2,
                      SalesTax3,
                      SalesTaxRate,
                      SalesTaxRate1,
                      SalesTaxRate2,
                      SalesTaxRate3,
                      row["ShipAddress1"].ToString(),
                      row["ShipAddress2"].ToString(),
                      row["ShipCity"].ToString(),
                      row["ShipCompanyName"].ToString(),
                      row["ShipCountry"].ToString(),
                      row["ShipFaxNumber"].ToString(),
                      row["ShipFirstName"].ToString(),
                      row["ShipLastName"].ToString(),
                      row["ShipPhoneNumber"].ToString(),
                      (row["Shipping_Locked"].ToString().ToCharArray())[0],
                      (row["ShippingMethodID"].ToString().ToCharArray())[0],
                      (row["ShipResidential"].ToString().ToCharArray())[0],
                     
                      row["ShipState"].ToString(),
                     row["ShipPostalCode"].ToString(),
                      (row["Stock_Priority"].ToString().ToCharArray())[0],
                      row["Tax1_Title"].ToString(),
                      row["Tax2_Title"].ToString(),
                      row["Tax3_Title"].ToString(),
                      Total_Payment_Authorized,
                      Total_Payment_Received,
                      TotalShippingCost,
                      VendorID, null, subid);
                    }
                    catch (Exception e)
                    {
                        poop.AddError(e.Message);
                    }
                }
                foreach (DataRow row in data.Tables[1].Rows)
                {
                    int OrderDetailID = 0;
                    int KitID = 0;
                    int OnOrder_Qty = 0;
                    int OptionIDs = 0;
                    int OrderID = 0;
                    int ProductID = 0;
                    decimal ProductPrice = 0;
                    int ProductWeight = 0;
                    int QtyOnBackOrder = 0;
                    int QtyOnHold = 0;
                    int QtyShipped = 0;
                    int Quantity = 0;
                    decimal TotalPrice = 0;
                    decimal GiftWrapCost = 0;

                    int.TryParse(row["OrderDetailID"].ToString(), out OrderDetailID);
                    int.TryParse(row["KitID"].ToString(), out KitID);
                    int.TryParse(row["OnOrder_Qty"].ToString(), out OnOrder_Qty);
                    int.TryParse(row["OptionIDs"].ToString(), out OptionIDs);
                    int.TryParse(row["OrderID"].ToString(), out OrderID);
                    int.TryParse(row["ProductID"].ToString(), out ProductID);
                    decimal.TryParse(row["ProductPrice"].ToString(), out ProductPrice);
                    decimal.TryParse(row["GiftWrapCost"].ToString(), out GiftWrapCost);
                    int.TryParse(row["ProductWeight"].ToString(), out ProductWeight);
                    int.TryParse(row["QtyOnBackOrder"].ToString(), out QtyOnBackOrder);
                    int.TryParse(row["QtyOnHold"].ToString(), out QtyOnHold);
                    int.TryParse(row["QtyShipped"].ToString(), out QtyShipped);
                    int.TryParse(row["Quantity"].ToString(), out Quantity);
                    decimal.TryParse(row["TotalPrice"].ToString(), out TotalPrice);

                    char? AutoDropShip = null;
                    char? FreeShippingItem = null;
                    char? GiftTrakNumber = null;
                    char? GiftWrap = null;
                    char? IsKitID = null;
                    char? Locked = null;
                    try
                    {
                        AutoDropShip = (row["AutoDropShip"].ToString().ToCharArray())[0];
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        FreeShippingItem = (row["FreeShippingItem"].ToString().ToCharArray())[0];
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GiftTrakNumber = (row["GiftTrakNumber"].ToString().ToCharArray())[0];
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        GiftWrap = (row["GiftWrap"].ToString().ToCharArray())[0];
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        IsKitID = (row["IsKitID"].ToString().ToCharArray())[0];
                    }
                    catch (Exception)
                    {


                    }
                    try
                    {
                        Locked = (row["Locked"].ToString().ToCharArray())[0];

                    }
                    catch (Exception)
                    {


                    }
                    try
                    {

                        poop.UpdateorInsertOrderDetails(OrderDetailID,
                       AutoDropShip,
                       FreeShippingItem,
                       GiftTrakNumber,
                       GiftWrap,
                       GiftWrapCost,
                       row["GiftWrapNote"].ToString(),
                       IsKitID,
                       KitID,
                       Locked,
                       OnOrder_Qty,
                       OptionIDs,
                       row["Options"].ToString(),
                       OrderID,
                       row["ProductCode"].ToString(),
                       ProductID,
                       row["ProductName"].ToString(),
                       ProductPrice,
                       ProductWeight,
                       QtyOnBackOrder,
                       QtyOnHold,
                       QtyShipped,
                       Quantity,
                       TotalPrice,
                       row["Warehouses"].ToString()
                       );
                    }
                    catch (Exception e)
                    {

                        poop.AddError(e.Message);
                    }
                }
            }
       
            
           
        }
        public static decimal? GetGift(string orgid)
        {
            PoopStatsDataContext poop = new PoopStatsDataContext(ConfigurationManager.ConnectionStrings["poopstatsConnectionString"].ConnectionString);

            decimal? ret = 0;
            try
            {
 
                var result = poop.GetGiftTotal(orgid);
                foreach (var c in result)
                {
                    ret = c.Total;
                }
            }
            catch (Exception e)
            {
                poop.AddError(e.Message);
            }
            return ret;
        }
        public static string Getname(string orgid)
        {
            string ret=orgid ;
            PoopStatsDataContext poop = new PoopStatsDataContext(ConfigurationManager.ConnectionStrings["poopstatsConnectionString"].ConnectionString);
            try
            {

                var result = poop.GetOrgName(orgid);
                foreach (var c in result)
                {
                    ret = c.ORG_name;
                }
                if ( ret== "")
                {
                    ret = orgid;
                }
            }
            catch (Exception e)
            {
                poop.AddError(e.Message);
            }
            return ret;
        }
        static private DataSet Get_Data(string url)
        {
            try
            {

                XmlDocument APIDoc = null;
                XmlTextReader reader = new XmlTextReader(url);
                APIDoc = new XmlDocument();
                APIDoc.Load(reader);
                reader.Close();
               
                MemoryStream ms = new MemoryStream();
               // APIDoc.Save(@"C:\orders.xml");
                APIDoc.Save(ms);
                
                ms.Seek(0, 0);
                DataSet Data = new DataSet();
                Data.ReadXml(ms, XmlReadMode.Auto);
                
                return Data;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}