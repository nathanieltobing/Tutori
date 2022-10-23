using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tutori.Model;
using Tutori.Repository;

namespace Tutori.View
{
    public partial class studentlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        StudentRepository sRepo = new StudentRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text.Trim();
            string password = TextBox2.Text.Trim();

            if (sRepo.checkLogin(username, password))
            {
                Response.Write("<script>alert('Login Successful');</script>");

                Response.Redirect("homepage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid credentials');</script>");
            }




        }
    }
}