using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;
using System.Data;
using System.Configuration;

namespace P_O_O_P
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
                    string AccountNumber = "";
                    string AccountType = "";
                    string AddressValidated = "";
                    string AuthHash = "";
                    string BankName = "";
                    string BillingAddress1 = "";
                    string BillingAddress2 = "";
                    string BillingCity = "";
                    string BillingCompanyName = "";
                    string BillingCountry = "";
                    string BillingFaxNumber = "";
                    string BillingFirstName = "";
                    string BillingLastName = "";
                    string BillingPhoneNumber = "";
                    string BillingPostalCode = "";
                    string BillingState = "";
                    string CardHoldersName = "";
                    string CreditCardIssueNumber = "";
                    string Customer_IPAddress = "";
                    string IsAGift = "";
                    string Locked = "";
                    string MICR = "";
                    string Order_Comments = "";
                    string Order_Entry_System = "";
                    string OrderStatus = "";
                    string PONum = "";
                    string RoutingNumber = "";
                    string ShipAddress1 = "";
                    string ShipAddress2 = "";
                    string ShipCity = "";
                    string ShipCompanyName = "";
                    string ShipCountry = "";
                    string ShipFaxNumber = "";
                    string ShipFirstName = "";
                    string ShipLastName = "";
                    string ShipPhoneNumber = "";
                    string Shipping_Locked = "";
                    string ShippingMethodID = "";
                    string ShipResidential = "";
                    string ShipState = "";
                    string ShipPostalCode = "";
                    string Stock_Priority = "";
                    string Tax1_Title = "";
                    string Tax2_Title = "";
                    string Tax3_Title = "";
                    if (row.Table.Columns.Contains("AccountNumber")) { AccountNumber = row["AccountNumber"].ToString(); }
                    if (row.Table.Columns.Contains("AccountType")) { AccountType = row["AccountType"].ToString(); }
                    if (row.Table.Columns.Contains("AddressValidated")) { AddressValidated = row["AddressValidated"].ToString(); }
                    if (row.Table.Columns.Contains("AuthHash")) { AuthHash = row["AuthHash"].ToString(); }
                    if (row.Table.Columns.Contains("BankName")) { BankName = row["BankName"].ToString(); }
                    if (row.Table.Columns.Contains("BillingAddress1")) { BillingAddress1 = row["BillingAddress1"].ToString(); }
                    if (row.Table.Columns.Contains("BillingAddress2")) { BillingAddress2 = row["BillingAddress2"].ToString(); }
                    if (row.Table.Columns.Contains("BillingCity")) { BillingCity = row["BillingCity"].ToString(); }
                    if (row.Table.Columns.Contains("BillingCompanyName")) { BillingCompanyName = row["BillingCompanyName"].ToString(); }
                    if (row.Table.Columns.Contains("BillingCountry")) { BillingCountry = row["BillingCountry"].ToString(); }
                    if (row.Table.Columns.Contains("BillingFaxNumber")) { BillingFaxNumber = row["BillingFaxNumber"].ToString(); }
                    if (row.Table.Columns.Contains("BillingFirstName")) { BillingFirstName = row["BillingFirstName"].ToString(); }
                    if (row.Table.Columns.Contains("BillingLastName")) { BillingLastName = row["BillingLastName"].ToString(); }
                    if (row.Table.Columns.Contains("BillingPhoneNumber")) { BillingPhoneNumber = row["BillingPhoneNumber"].ToString(); }
                    if (row.Table.Columns.Contains("BillingPostalCode")) { BillingPostalCode = row["BillingPostalCode"].ToString(); }
                    if (row.Table.Columns.Contains("BillingState")) { BillingState = row["BillingState"].ToString(); }
                    if (row.Table.Columns.Contains("CardHoldersName")) { CardHoldersName = row["CardHoldersName"].ToString(); }
                    if (row.Table.Columns.Contains("CreditCardIssueNumber")) { CreditCardIssueNumber = row["CreditCardIssueNumber"].ToString(); }
                    if (row.Table.Columns.Contains("Customer_IPAddress")) { Customer_IPAddress = row["Customer_IPAddress"].ToString(); }
                    if (row.Table.Columns.Contains("IsAGift")) { IsAGift = row["IsAGift"].ToString(); }
                    if (row.Table.Columns.Contains("Locked")) { Locked = row["Locked"].ToString(); }
                    if (row.Table.Columns.Contains("MICR")) { MICR = row["MICR"].ToString(); }
                    if (row.Table.Columns.Contains("Order_Comments")) { Order_Comments = row["Order_Comments"].ToString(); }
                    if (row.Table.Columns.Contains("Order_Entry_System")) { Order_Entry_System = row["Order_Entry_System"].ToString(); }
                    if (row.Table.Columns.Contains("OrderStatus")) { OrderStatus = row["OrderStatus"].ToString(); }
                    if (row.Table.Columns.Contains("PONum")) { PONum = row["PONum"].ToString(); }
                    if (row.Table.Columns.Contains("RoutingNumber")) { RoutingNumber = row["RoutingNumber"].ToString(); }
                    if (row.Table.Columns.Contains("ShipAddress1")) { ShipAddress1 = row["ShipAddress1"].ToString(); }
                    if (row.Table.Columns.Contains("ShipAddress2")) { ShipAddress2 = row["ShipAddress2"].ToString(); }
                    if (row.Table.Columns.Contains("ShipCity")) { ShipCity = row["ShipCity"].ToString(); }
                    if (row.Table.Columns.Contains("ShipCompanyName")) { ShipCompanyName = row["ShipCompanyName"].ToString(); }
                    if (row.Table.Columns.Contains("ShipCountry")) { ShipCountry = row["ShipCountry"].ToString(); }
                    if (row.Table.Columns.Contains("ShipFaxNumber")) { ShipFaxNumber = row["ShipFaxNumber"].ToString(); }
                    if (row.Table.Columns.Contains("ShipFirstName")) { ShipFirstName = row["ShipFirstName"].ToString(); }
                    if (row.Table.Columns.Contains("ShipLastName")) { ShipLastName = row["ShipLastName"].ToString(); }
                    if (row.Table.Columns.Contains("ShipPhoneNumber")) { ShipPhoneNumber = row["ShipPhoneNumber"].ToString(); }
                    if (row.Table.Columns.Contains("Shipping_Locked")) { Shipping_Locked = row["Shipping_Locked"].ToString(); }
                    if (row.Table.Columns.Contains("ShippingMethodID")) { ShippingMethodID = row["ShippingMethodID"].ToString(); }
                    if (row.Table.Columns.Contains("ShipResidential")) { ShipResidential = row["ShipResidential"].ToString(); }
                    if (row.Table.Columns.Contains("ShipState")) { ShipState = row["ShipState"].ToString(); }
                    if (row.Table.Columns.Contains("ShipPostalCode")) { ShipPostalCode = row["ShipPostalCode"].ToString(); }
                    if (row.Table.Columns.Contains("Stock_Priority")) { Stock_Priority = row["Stock_Priority"].ToString(); }
                    if (row.Table.Columns.Contains("Tax1_Title")) { Tax1_Title = row["Tax1_Title"].ToString(); }
                    if (row.Table.Columns.Contains("Tax2_Title")) { Tax2_Title = row["Tax2_Title"].ToString(); }
                    if (row.Table.Columns.Contains("Tax3_Title")) { Tax3_Title = row["Tax3_Title"].ToString(); }

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
                       AccountNumber,
                      AccountType,
                      (AddressValidated.ToCharArray())[0],
                      Affiliate_Commissionable_Value,
                      AuthHash,
                      BankName,
                      BillingAddress1,
                      BillingAddress2,
                      BillingCity,
                      BillingCompanyName,
                      BillingCountry,
                      BillingFaxNumber,
                      BillingFirstName,
                      BillingLastName,
                      BillingPhoneNumber,
                      BillingPostalCode,
                      BillingState,
                      CardHoldersName,
                      CC_Last4,
                      CheckNumber,
                      CreditCardExpDate,
                      CreditCardIssueDate,
                      CreditCardIssueNumber,
                      Customer_IPAddress,
                      CustomerID,
                      (IsAGift.ToCharArray())[0],
                      (Locked.ToCharArray())[0],
                      MICR,
                      Order_Comments,
                      Order_Entry_System,
                      OrderDate,
                      OrderStatus,
                      PaymentAmount,
                      PaymentMethodID,
                      PONum,
                      RoutingNumber,
                      SalesTax1,
                      SalesTax2,
                      SalesTax3,
                      SalesTaxRate,
                      SalesTaxRate1,
                      SalesTaxRate2,
                      SalesTaxRate3,
                      ShipAddress1,
                      ShipAddress2,
                      ShipCity,
                      ShipCompanyName,
                      ShipCountry,
                      ShipFaxNumber,
                      ShipFirstName,
                      ShipLastName,
                      ShipPhoneNumber,
                      (Shipping_Locked.ToCharArray())[0],
                      (ShippingMethodID.ToCharArray())[0],
                      (ShipResidential.ToCharArray())[0],

                      ShipState,
                     ShipPostalCode,
                      (Stock_Priority.ToCharArray())[0],
                      Tax1_Title,
                      Tax2_Title,
                      Tax3_Title,
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
                        string GiftWrapNote = "";
                        string Options= "";
                        string ProductCode = "";
                        string ProductName = "";
                        string Warehouses = "";
                        if (row.Table.Columns.Contains("GiftWrapNote")) { GiftWrapNote = row["GiftWrapNote"].ToString(); }
                        if (row.Table.Columns.Contains("Options")) { Options = row["Options"].ToString(); }
                        if (row.Table.Columns.Contains("ProductCode")) { ProductCode = row["ProductCode"].ToString(); }
                        if (row.Table.Columns.Contains("ProductName")) { ProductName = row["ProductName"].ToString(); }
                        if (row.Table.Columns.Contains("Warehouses")) { Warehouses = row["Warehouses"].ToString(); }
                        poop.UpdateorInsertOrderDetails(OrderDetailID,
                       AutoDropShip,
                       FreeShippingItem,
                       GiftTrakNumber,
                       GiftWrap,
                       GiftWrapCost,
                       GiftWrapNote,
                       IsKitID,
                       KitID,
                       Locked,
                       OnOrder_Qty,
                       OptionIDs,
                       Options,
                       OrderID,
                       ProductCode,
                       ProductID,
                       ProductName,
                       ProductPrice,
                       ProductWeight,
                       QtyOnBackOrder,
                       QtyOnHold,
                       QtyShipped,
                       Quantity,
                       TotalPrice,
                       Warehouses
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