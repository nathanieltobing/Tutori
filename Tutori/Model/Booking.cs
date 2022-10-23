using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutori.Model
{
    public class Booking
    {
        private string bookingID;
        private string media;
        private string place_application;
        private string total_hours;
        private string time;
        private string debit;
        private string tutor_name;
        private string tutor_username;
        private string student_name;
        private string student_username;
        private string status;
        private string date;
        private string subject;
        private string tutoring_fee;
        private string tutoriFee;
        private string feeReceived;

        public Booking(string bookingID, string media, string place_application, string total_hours, string time, string debit, string tutor_name, string tutor_username, string student_name, string student_username, string status, string date, string subject, string tutoring_fee, string tutoriFee, string feeReceived)
        {
            this.BookingID = bookingID;
            this.Media = media;
            this.Place_application = place_application;
            this.Total_hours = total_hours;
            this.Time = time;
            this.Debit = debit;
            this.Tutor_name = tutor_name;
            this.Tutor_username = tutor_username;
            this.Student_name = student_name;
            this.Student_username = student_username;
            this.Status = status;
            this.Date = date;
            this.Subject = subject;
            this.Tutoring_fee = tutoring_fee;
            this.TutoriFee = tutoriFee;
            this.FeeReceived = feeReceived;
        }

        public string BookingID { get => bookingID; set => bookingID = value; }
        public string Media { get => media; set => media = value; }
        public string Place_application { get => place_application; set => place_application = value; }
        public string Total_hours { get => total_hours; set => total_hours = value; }
        public string Time { get => time; set => time = value; }
        public string Debit { get => debit; set => debit = value; }
        public string Tutor_name { get => tutor_name; set => tutor_name = value; }
        public string Tutor_username { get => tutor_username; set => tutor_username = value; }
        public string Student_name { get => student_name; set => student_name = value; }
        public string Student_username { get => student_username; set => student_username = value; }
        public string Status { get => status; set => status = value; }
        public string Date { get => date; set => date = value; }
        public string Subject { get => subject; set => subject = value; }

        public string Tutoring_fee { get => tutoring_fee; set => tutoring_fee = value; }

        public string TutoriFee { get => tutoriFee; set => tutoriFee = value; }

        public string FeeReceived { get => feeReceived; set => feeReceived = value; }

    }
}