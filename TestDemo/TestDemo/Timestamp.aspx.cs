using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace TestDemo
{
    public partial class Timestamp : System.Web.UI.Page
    {
        DataTable dtTimestamp = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            { 
                dtTimestamp.Columns.Add(new DataColumn("Row"));
                dtTimestamp.Columns.Add(new DataColumn("TimeStamp"));
                gvTimeStamp.DataSource = dtTimestamp; 
                gvTimeStamp.DataBind();
                ViewState["dtTime"] = dtTimestamp;
            }
        }

        protected void btnLogTime_Click(object sender, EventArgs e)
        {
            dtTimestamp = (DataTable)ViewState["dtTime"];
            DataRow dr = dtTimestamp.NewRow();
            dr[0] = dtTimestamp.Rows.Count+1;
            dr[1] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            dtTimestamp.Rows.Add(dr);
            gvTimeStamp.DataSource = dtTimestamp;
            gvTimeStamp.DataBind();
        }

        protected void lnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}