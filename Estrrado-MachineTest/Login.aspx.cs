using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estrrado_MachineTest
{
    public partial class Login : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strCheck = "select count(Student_Id) from RegTb where Username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
            string cid = objcls.Fn_Scalar(strCheck);

            if (cid == "1")
            {
                string strId = "select Student_Id from RegTb where Username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
                string id = objcls.Fn_Scalar(strId);
                Session["usid"] = id;
                Response.Redirect("StudentList.aspx");
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "Invalid UserName Or Password";
            }
        }
    }
}