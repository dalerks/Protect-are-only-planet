using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POOP
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id;
            if (TextBox1.Text == "")
            {
                id = DropDownList1.SelectedItem.Value.ToString();
            }
            else{
                id = TextBox1.Text;
                }
            Response.Redirect("Stats.aspx?ORGID=" + id);
        }
    }
}
