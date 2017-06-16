using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestDemo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void lnkRounding_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rounding.aspx") ;
        }

        protected void lnkTimeStamp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Timestamp.aspx");
        }
    }
}