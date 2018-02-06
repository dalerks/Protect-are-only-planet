using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;
using System.IO;

namespace P_O_O_P
{
    public partial class Stats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string orgid = "";
            string name="";
            try
            {
                try
                {
                    POOPDATA.Get_Orders();
                }
                catch (Exception)
                {
                     
                  
                }
                 orgid = Request.QueryString["ORGID"];
                orgid = orgid.ToUpper();
                decimal? total = POOPDATA.GetGift(orgid);
                 name = POOPDATA.Getname(orgid);
                Label1.Text = name + " has raised a total of $" + total.ToString().Remove(total.ToString().Length - 2);
            }
            catch (Exception err)
            {
                Label1.Text = "Be the first to direct a gift at checkout to "+name;
            }
        }

    }
}