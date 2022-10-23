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
    public partial class studentviewprofile : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"].ToString() == "" || Session["username"] == null)
                {
                    Response.Write("<script>alert('Session Expired Login Again');</script>");
                    Response.Redirect("studentlogin.aspx");
                }
                else
                {
                    if (!Page.IsPostBack)
                    {
                        getUserPersonalDetails();
                    }


                }
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('Session Expired Login Again');</script>");
                Response.Redirect("studentlogin.aspx");
            }

        }
        // update button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["username"].ToString() == "" || Session["username"] == null)
            {
                Response.Write("<script>alert('Session Expired Login Again');</script>");
                Response.Redirect("studentlogin.aspx");
            }
            else
            {
                   updateUserPersonalDetails();

            }
        }

        void updateUserPersonalDetails()
        {
            string password = "";
            if (Tnpassword.Text.Trim() == "")
            {
                password = Topassword.Text.Trim();
            }
            else
            {
                password = Tnpassword.Text.Trim();
            }
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("update student_master_tbl set first_name=@first_name, last_name=@last_name, fullname=@fullname,email=@email, state=@state, city=@city, address=@address, school=@school, dob=@dob,password=@password,debit_card=@debit_card WHERE username='" + Session["username"].ToString().Trim() + "'", con);

                cmd.Parameters.AddWithValue("@first_name", TfirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@last_name", TlastName.Text.Trim());
                string fullname = TfirstName.Text.Trim() + " " + TlastName.Text.Trim();
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@email", Temail.Text.Trim());
                cmd.Parameters.AddWithValue("@state", Tstate.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@city", Tcity.Text.Trim());
                
                cmd.Parameters.AddWithValue("@address", Taddress.Text.Trim());
                cmd.Parameters.AddWithValue("@school", Tschool.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", Tdob.Text.Trim());
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@debit_card", "dob");

                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {

                    Response.Write("<script>alert('Your Profile Updated Successfully');</script>");
                    getUserPersonalDetails();
                 
                }
                else
                {
                    Response.Write("<script>alert('Invaid entry');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void getUserPersonalDetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from student_master_tbl where username='" + Session["username"].ToString() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Image1.ImageUrl = dt.Rows[0]["profile_img_link"].ToString();
                //Image1.ImageUrl = "~/book_inventory/fotosendiri.jpg";
                TfirstName.Text = dt.Rows[0]["first_name"].ToString();
                TlastName.Text = dt.Rows[0]["last_name"].ToString();
                Tdob.Text = dt.Rows[0]["dob"].ToString();
                Temail.Text = dt.Rows[0]["email"].ToString();
                Tstate.SelectedValue = dt.Rows[0]["state"].ToString().Trim();
                Tcity.Text = dt.Rows[0]["city"].ToString();
                Tschool.Text = dt.Rows[0]["school"].ToString();
                Tdebit.Text = dt.Rows[0]["debit_card"].ToString();
                Taddress.Text = dt.Rows[0]["address"].ToString();
                Tusername.Text = dt.Rows[0]["username"].ToString();
                Topassword.Text = dt.Rows[0]["password"].ToString();
              


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
    }
}