using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Estrrado_MachineTest
{
    public partial class StudentReg : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string selectedDate = Calendar1.SelectedDate.ToString("yyyy-MM-dd");

            string strins = "insert into RegTb values('" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ",'"+TextBox4.Text+"','" + RadioButtonList1.SelectedItem.Text + "','" + TextBox5.Text + "'," + TextBox6.Text + ",'" + TextBox7.Text + "','" + TextBox8.Text + "')";
            int i = objcls.Fn_NonQuery(strins);
            if (i == 1)
            {
                Response.Redirect("Login.aspx");
            }
            
        }

        
    }
}