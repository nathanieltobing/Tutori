using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutori.Model
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string fullName;
        private string email;
        private string state;
        private string city;
        private string address;
        private string school;
        private string dob;
        private string status;
        private string userName;
        private string password;
        private string debit;
        private string profileImgLink;

        public Student(string firstName, string lastName, string fullName, string email, string state, string city, string address, string school, string dob, string status, string userName, string password, string debit, string profileImgLink)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.Email = email;
            this.State = state;
            this.City = city;
            this.Address = address;
            this.School = school;
            this.Dob = dob;
            this.Status = status;
            this.UserName = userName;
            this.Password = password;
            this.Debit = debit;
            this.ProfileImgLink = profileImgLink;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string State { get => state; set => state = value; }
        public string City { get => city; set => city = value; }
        public string Address { get => address; set => address = value; }
        public string School { get => school; set => school = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Status { get => status; set => status = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Debit { get => debit; set => debit = value; }
        public string ProfileImgLink { get => profileImgLink; set => profileImgLink = value; }
    }
}