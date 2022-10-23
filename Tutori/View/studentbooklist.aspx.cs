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
    public partial class studentbooklist : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        BookingRepository bRepo = new BookingRepository();
        SqlDataSource SqlDataSource1 = new SqlDataSource();

        protected void Page_Load(object sender, EventArgs e)
        {

                string username = Session["username"].ToString();
                SqlDataSource1.ID = "SqlDataSource1";
                this.Page.Controls.Add(SqlDataSource1);
                SqlDataSource1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TutoriConnectionString"].ConnectionString;
                SqlDataSource1.SelectCommand = "SELECT * from booking_master_tbl where student_username = '" +username+ "'";
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();

            
            
        }    
        // confirm cancellation
        protected void Button2_Click(object sender, EventArgs e)
        {
            ConfirmCancelDenial();
        }
        //cancel booking
        protected void Button1_Click(object sender, EventArgs e)
        {
            updateBookingStatusByID("Cancelled");
        }
        //confirm denial
        protected void Button3_Click(object sender, EventArgs e)
        {
            ConfirmCancelDenial();
        }
       
        //update status
        void updateBookingStatusByID(string status)
        {
            string bookingID = TbookingID.Text.Trim();
            if (bRepo.checkIfBookingExisted(bookingID))
            {
                bRepo.updateStatus(status, bookingID);
                GridView1.DataBind();
                Response.Write("<script>alert('Booking Cancelled');</script>");
            }
            else
            {
                Response.Write("<script>alert('Invalid Booking ID');</script>");
            }

        }

        void ConfirmCancelDenial()
        {
            string bookingID = TbookingID.Text.Trim();
            if (bRepo.checkIfBookingExisted(bookingID))
            {
                bRepo.deleteBooking(bookingID);
                clearForm();
                GridView1.DataBind();
               

            }
            else
            {
                Response.Write("<script>alert('Invalid Booking ID');</script>");
            }
        }
        void clearForm()
        {
            TbookingID.Text = "";
            
        }
    }
}