using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Tutori.Model;
using Tutori.Repository;


namespace Tutori.View
{
    public partial class booksession : System.Web.UI.Page
    {
        BookingRepository bRepo = new BookingRepository();
        TutorRepository tRepo = new TutorRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        //book
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = Tusername.Text.Trim();
            
            
                if (tRepo.checkIfUserExisted(username))
                {
                    Tutor tutor = tRepo.getTutor(Tusername.Text.Trim());
                    Random rd = new Random();
                    string bookingID = "book-" + rd.Next(0, 10) + rd.Next(0, 10) + rd.Next(0, 10);
                    string media = Tmedia.SelectedItem.Value;
                    string place_application = Tplaceapplication.Text.Trim();
                    string total_hours = Ttotalhours.Text.Trim();
                    string time = Ttime.Text.Trim();
                    string debit = Tdebit.Text.Trim();
                    string tutor_name = tutor.FullName;
                    string tutor_username = Tusername.Text.Trim();
                    string student_name = Session["fullname"].ToString();
                    string student_username = Session["username"].ToString();
                    string status = "Pending";
                    string date = Tdebit.Text.Trim();
                    string subjects = Tsubject.Text.Trim();

                    int hours = Convert.ToInt32(Ttotalhours.Text.Trim());
                    int fee = Convert.ToInt32(tutor.TutoringFee);
                    int total_fee = hours * fee;
                    string tutoringFee = total_fee.ToString();

                    
                    double temp = (double)total_fee *20/100;
                    int tempTutoriFee = (int)temp;
                    string tutoriFee = tempTutoriFee.ToString();

                    int tempFeeReceived = total_fee - tempTutoriFee;
                    string feeReceived = tempFeeReceived.ToString();


                    Booking book = new Booking(bookingID, media, place_application, total_hours, time, debit, tutor_name
                        , tutor_username, student_name, student_username, status, date, subjects, tutoringFee,tutoriFee,feeReceived);

                    bRepo.addBooking(book);
                    Response.Write("<script>alert('Booking Successful');</script>");
                }
                else
                {                 
                   
                Response.Write("<script>alert('Tutor username does not exists.');</script>");

            }
                           


            
            
        }


       
    }
}