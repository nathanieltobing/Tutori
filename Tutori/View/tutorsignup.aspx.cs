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
    public partial class tutorsignup : System.Web.UI.Page
    {
        TutorRepository tRepo = new TutorRepository();
        static string global_filepath;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = "~/book_inventory/generaluser.png";
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("../book_inventory/" + filename));
                filepath = "~/book_inventory/" + filename;

                string firstName = TfirstName.Text.Trim();
                string lastName = TlastName.Text.Trim();
                string fullName = firstName + " " + lastName;
                string username = Tusername.Text.Trim(); ;
                string dob = Tdob.Text.Trim();
                string email = Temail.Text.Trim();
                string state = Tstate.SelectedItem.Value;
                string city = Tcity.Text.Trim();
                string school = Tschool.Text.Trim();
                string address = Taddress.Text.Trim();
                string password = Tpassword.Text.Trim();
                string status = "Tutor";
                string debit = Tdebit.Text.Trim();
                string profileImgLink = filepath;
                string subjects = Tsubject.Text.Trim();
                string biodata = Tbiodata.Text.Trim();
                string tutoringFee = TtutoringFee.Text.Trim();


                Tutor tutor = new Tutor(firstName, lastName, fullName, email, school, subjects,
                    biodata, state, city, address, status, username, password, debit, tutoringFee,
                    profileImgLink, dob);



                if (tRepo.checkIfUserExisted(tutor.UserName))
                {
                    Response.Write("<script>alert('Username already Existed');</script>");
                }
                else
                {
                    tRepo.signUp(tutor);
                    Response.Write("<script>alert('Sign up successful.');</script>");
                    Response.Redirect("tutorlogin.aspx");

                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }


        }
    }
}