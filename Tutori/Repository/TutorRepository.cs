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
    public class TutorRepository : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public void signUp(Tutor tutor)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) //check whether the connection is connected to the db or not
                {
                    //if the connection state is closed, we want to open it
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO tutor_master_tbl(first_name,last_name,fullname,email,school,subjects,biodata,state,city,address,status,username,password,debit_card,tutoring_fee,profile_img_link,dob) values(@first_name,@last_name,@fullname,@email,@school,@subjects,@biodata,@state,@city,@address,@status,@username,@password,@debit_card,@tutoring_fee,@profile_img_link,@dob)", con);

                cmd.Parameters.AddWithValue("@first_name", tutor.FirstName);
                cmd.Parameters.AddWithValue("@last_name", tutor.LastName);
                cmd.Parameters.AddWithValue("@fullname", tutor.FullName);
                cmd.Parameters.AddWithValue("@email", tutor.Email);
                cmd.Parameters.AddWithValue("@school", tutor.School);
                cmd.Parameters.AddWithValue("@subjects", tutor.Subjects);
                cmd.Parameters.AddWithValue("@biodata", tutor.Biodata);
                cmd.Parameters.AddWithValue("@state", tutor.State);
                cmd.Parameters.AddWithValue("@city", tutor.City);
                cmd.Parameters.AddWithValue("@address", tutor.Address);                
                cmd.Parameters.AddWithValue("@status", tutor.Status);
                cmd.Parameters.AddWithValue("@username", tutor.UserName);
                cmd.Parameters.AddWithValue("@password", tutor.Password);
                cmd.Parameters.AddWithValue("@debit_card", tutor.Debit);
                cmd.Parameters.AddWithValue("@tutoring_fee", tutor.TutoringFee);
                cmd.Parameters.AddWithValue("@profile_img_link", tutor.ProfileImgLink);
                cmd.Parameters.AddWithValue("@dob", tutor.Dob);

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
                SqlCommand cmd = new SqlCommand("select * from tutor_master_tbl where username = " +
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
                SqlCommand cmd = new SqlCommand("select * from tutor_master_tbl where username='" + username + "' AND password='" + password + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        Session["first_name"] = dr.GetValue(0).ToString();
                        Session["role"] = "tutor"; //( user itu member)
                        Session["username"] = dr.GetValue(11).ToString();
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

        public Tutor getTutor(string username)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("select * from tutor_master_tbl where username='" + username + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    
                    while (dr.Read())
                    {
                        Tutor tutor = new Tutor("", "", dr.GetValue(2).ToString(), "", "", "", "", "", "", "", "", username, "", "", dr.GetValue(14).ToString(), "", "");
                        return tutor;
                    }
                    return null;

                }
                else
                {

                    return null;
                }

            }
            catch (Exception ex)
            {
                // Response.Write("<script>alert('" + ex.Message + "');</script>");
                return null;
            }
        }
    }
}