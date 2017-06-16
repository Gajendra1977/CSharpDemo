using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestDemo
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack) 
            {                
                lblTimer.Text =  DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
        }

        protected void tMain_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");            
            upTimer.Update();
        }
    }
}