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
    public class BookingRepository : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public void addBooking(Booking book)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) //check whether the connection is connected to the db or not
                {
                    //if the connection state is closed, we want to open it
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO booking_master_tbl(bookingID,media,place_application,total_hours,time,debit,tutor_name,tutor_username,student_name,student_username,status,date,subject,tutoring_fee,tutoriFee,feeReceived) values(@bookingID,@media,@place_application,@total_hours,@time,@debit,@tutor_name,@tutor_username,@student_name,@student_username,@status,@date,@subject,@tutoring_fee,@tutoriFee,@feeReceived)", con);

                cmd.Parameters.AddWithValue("@bookingID", book.BookingID);
                cmd.Parameters.AddWithValue("@media", book.Media);
                cmd.Parameters.AddWithValue("@place_application", book.Place_application);
                cmd.Parameters.AddWithValue("@total_hours", book.Total_hours);
                cmd.Parameters.AddWithValue("@time", book.Time);
                cmd.Parameters.AddWithValue("@debit", book.Debit);
                cmd.Parameters.AddWithValue("@tutor_name", book.Tutor_name);
                cmd.Parameters.AddWithValue("@tutor_username", book.Tutor_username);
                cmd.Parameters.AddWithValue("@student_name", book.Student_name);
                cmd.Parameters.AddWithValue("@student_username", book.Student_username);
                cmd.Parameters.AddWithValue("@status", book.Status);
                cmd.Parameters.AddWithValue("@date", book.Date);
                cmd.Parameters.AddWithValue("@subject", book.Subject);
                cmd.Parameters.AddWithValue("@tutoring_fee", book.Tutoring_fee);
                cmd.Parameters.AddWithValue("@tutoriFee", book.TutoriFee);
                cmd.Parameters.AddWithValue("@feeReceived", book.FeeReceived);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

                //Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        public void updateStatus(string status, string bookingID)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("UPDATE booking_master_tbl SET status='" + status + "' WHERE bookingID='" + bookingID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();



            }
            catch (Exception ex)
            {
               
            }
        }

        public bool checkIfBookingExisted(string bookingID)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) //check whether the connection is connected to the db or not
                {
                    //if the connection state is closed, we want to open it
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from booking_master_tbl where bookingID = " +
                  "'" + bookingID + "'", con);
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

        public void deleteBooking(string bookingID)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from booking_master_tbl WHERE bookingID='" + bookingID + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();



            }
            catch (Exception ex)
            {

            }
        }

    }
}