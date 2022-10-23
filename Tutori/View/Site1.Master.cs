using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tutori.View
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    LinkButton1.Visible = true; // login as student
                    LinkButton5.Visible = true; //Login as tutor
                    LinkButton2.Visible = true; // sign up as tutor
                    LinkButton4.Visible = true; //Sign up as student
                    LinkButton3.Visible = false; //logout link button
                    LinkButton7.Visible = false; //hello tutor link button
                    LinkButton8.Visible = false; //hello student
                    TtutorBookList.Visible = false; //tutorBookList
                    Tbooksession.Visible = false; //book session
                    TstudentBookList.Visible = false; //studentBooklist

                    LinkButton6.Visible = false; // admin login link button                   
                    LinkButton10.Visible = false; // member management link button
                }
                else if (Session["role"].Equals("student"))
                {
                    LinkButton1.Visible = false; // login as student
                    LinkButton5.Visible = false; //Login as tutor
                    LinkButton2.Visible = false; // sign up as tutor
                    LinkButton4.Visible = false; //Sign up as student
                    Tbooksession.Visible = true; //book session
                    TstudentBookList.Visible = true; //studentBooklist
                    LinkButton3.Visible = true; //logout link button
                    LinkButton7.Visible = false; //hello tutor link button
                    LinkButton8.Visible = true; //hello student
                    TtutorBookList.Visible = false; //tutorBookList

                    LinkButton8.Text = "Hello " + Session["first_name"].ToString();

                        LinkButton6.Visible = false; // admin login link button
                        
                        LinkButton10.Visible = false; // member management link button
                 
                        
                    
                }
                else if (Session["role"].Equals("tutor"))
                {
                    LinkButton1.Visible = false; // login as student
                    LinkButton5.Visible = false; //Login as tutor
                    LinkButton2.Visible = false; // sign up as tutor
                    LinkButton4.Visible = false; //Sign up as student
                    Tbooksession.Visible = false; //book session
                    TstudentBookList.Visible = false; //studentBooklist
                    TtutorBookList.Visible = true; //tutorBookList
                    LinkButton3.Visible = true; //logout link button
                    LinkButton7.Visible = true; //hello tutor link button
                    LinkButton8.Visible = false; //hello student
                    LinkButton7.Text = "Hello Tutor" ;

                    LinkButton6.Visible = false; // admin login link button

                    LinkButton10.Visible = false; // member management link button
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void Tbooksession_Click(object sender, EventArgs e)
        {
            Response.Redirect("booksession.aspx");
        }

        protected void TstudentBookList_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentbooklist.aspx");
        }

        protected void TtutorBookList_Click(object sender, EventArgs e)
        {
            Response.Redirect("tutorbooklist.aspx");
        }

        

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminusermanagement.aspx");
        }

        //sign up as student
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentsignup.aspx");
        }
        //login as student
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentlogin.aspx");
        }

        //sign up as tutor
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("tutorsignup.aspx");
        }
        //login as tutor
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("tutorlogin.aspx");
        }

        //logout button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = null;          
            Session["role"] = null;
           

            LinkButton1.Visible = true; // login as student
            LinkButton5.Visible = true; //Login as tutor
            LinkButton2.Visible = true; // sign up as tutor
            LinkButton4.Visible = true; //Sign up as student
            Tbooksession.Visible = false; //book session
            TstudentBookList.Visible = false; //studentBooklist
            TtutorBookList.Visible = false;
            LinkButton3.Visible = false; //logout link button
            LinkButton7.Visible = false; //hello tutor
            LinkButton8.Visible = false; //hello student

            LinkButton6.Visible = false; // admin login link button         
            LinkButton10.Visible = false; // member management link button

            Response.Redirect("homepage.aspx");
        }

        // view profile tutor
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("tutorviewprofile.aspx");
        }
        //view profile student
        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentviewprofile.aspx");
        }
       
    }
}