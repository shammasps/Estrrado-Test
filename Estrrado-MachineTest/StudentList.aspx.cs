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
    public partial class StudentList : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

            string struser = "select * from RegTb where Student_Id=" + Session["usid"] + "";
            SqlDataReader dr = objcls.Fn_Reader(struser);
            while (dr.Read())
            {
                Label1.Text = dr["First_Name"].ToString();
                Label2.Text = dr["Last_Name"].ToString();
                Label3.Text = dr["Age"].ToString();
                Label4.Text = dr["DOB"].ToString();
                Label5.Text = dr["Gender"].ToString();
                Label6.Text = dr["Email"].ToString();
                Label7.Text = dr["Phone_No"].ToString();
    
            }

        }

        protected void button2_click(object sender, EventArgs e)
        {
            string strQ = "insert into QualificationsTB values("+Session["usid"]+",'" + textbox9.Text + "','" + textbox10.Text + "'," + textbox11.Text + "," + textbox12.Text + ")";
            int i = objcls.Fn_NonQuery(strQ);
            if (i == 1)
            {
                string grid = "select Course, University, Year, Percentage from QualificationsTB where Student_Id=" + Session["usid"] + "";
                DataSet ds = objcls.Fn_Adapter(grid);
                gridview1.DataSource = ds;
                gridview1.DataBind();
                gridview1.Visible = true;
            }


        }
    }
}