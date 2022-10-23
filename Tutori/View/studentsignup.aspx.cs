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
    public partial class studentsignup : System.Web.UI.Page
    {
        StudentRepository sRepo = new StudentRepository();
        static string global_filepath;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //signup
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
                string status = "Student";
                string debit = Tdebit.Text.Trim();
                string profileImgLink = filepath;


                Student student = new Student(firstName, lastName, fullName, email, state, city, address,
                    school, dob, status, username, password, debit, profileImgLink);



                if (sRepo.checkIfUserExisted(student.UserName))
                {
                    Response.Write("<script>alert('Username already Existed');</script>");
                }
                else
                {
                    sRepo.signUp(student);
                    Response.Write("<script>alert('Sign up successful.');</script>");
                    Response.Redirect("studentlogin.aspx");

                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
           

        }
    }
}