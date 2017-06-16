using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestDemo
{
    public partial class Rounding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                /*DateTime recordedTime = new DateTime();
                recordedTime = DateTime.ParseExact(txtDateTime.Text, "yyyy-MM-dd HH:mm", null);
                int mins = Convert.ToDateTime(txtDateTime.Text).Minute;
                int bracketMins = 0;
                bracketMins = ((mins / 15) + ((mins % 15) / 8)) * 15;
                lblroundedTime.Text = "Rounded Time:   " + DateTime.ParseExact(recordedTime.ToString("yyyy-MM-dd HH"), "yyyy-MM-dd HH", null).AddMinutes(bracketMins).ToString("yyy-MM-dd HH:mm");
                */

                // Moved logic tgo seperate  class file
                BusinessLogic objLogic = new BusinessLogic();
                lblroundedTime.Text = "Rounded Time:   " + objLogic.RoundUpDate(txtDateTime.Text);
            }
            catch(Exception ex)
            {
                //Log the error in DB/error files
                lblroundedTime.Text = "System was not able to do rounding";
            }            
        }

        protected void lnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}