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

namespace Tutori.Repository
{
    public class StudentRepository : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public void signUp(Student student)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) //check whether the connection is connected to the db or not
                {
                    //if the connection state is closed, we want to open it
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO student_master_tbl(first_name,last_name,fullname,email,state,city,address,school,dob,status,username,password,debit_card,profile_img_link) values(@first_name,@last_name,@fullname,@email,@state,@city,@address,@school,@dob,@status,@username,@password,@debit_card,@profile_img_link)", con);

                cmd.Parameters.AddWithValue("@first_name", student.FirstName);
                cmd.Parameters.AddWithValue("@last_name", student.LastName);
                cmd.Parameters.AddWithValue("@fullname", student.FullName);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@state", student.State);
                cmd.Parameters.AddWithValue("@city", student.City);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@school", student.School);
                cmd.Parameters.AddWithValue("@dob", student.Dob);
                cmd.Parameters.AddWithValue("@status", student.Status);
                cmd.Parameters.AddWithValue("@username", student.UserName);
                cmd.Parameters.AddWithValue("@password", student.Password);
                cmd.Parameters.AddWithValue("@debit_card", student.Debit);
                cmd.Parameters.AddWithValue("@profile_img_link", student.ProfileImgLink);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

                //Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        public bool checkIfUserExisted(string username)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) //check whether the connection is connected to the db or not
                {
                    //if the connection state is closed, we want to open it
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from student_master_tbl where username = " +
                  "'" + username + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool checkLogin(string username, string password)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("select * from student_master_tbl where username='" + username + "' AND password='" + password + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        Session["first_name"] = dr.GetValue(0).ToString();                       
                        Session["role"] = "student"; //( user itu member)
                        Session["username"] = dr.GetValue(10).ToString();
                        Session["fullname"] = dr.GetValue(2).ToString();

                    }
                    return true;
                }
                else
                {

                    return false;
                }

            }
            catch (Exception ex)
            {
                // Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
    }
}