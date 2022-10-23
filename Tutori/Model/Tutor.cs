using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutori.Model
{
    public class Tutor
    {
        private string firstName;
        private string lastName;
        private string fullName;
        private string email;
        private string school;
        private string subjects;
        private string biodata;
        private string state;
        private string city;
        private string address;
        private string status;
        private string userName;
        private string password;
        private string debit;
        private string tutoringFee;
        private string profileImgLink;
        private string dob;
      

        public Tutor(string firstName, string lastName, string fullName, string email, string school, string subjects, string biodata, string state, string city, string address, string status, string userName, string password, string debit, string tutoringFee, string profileImgLink, string dob)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.Email = email;
            this.School = school;
            this.Subjects = subjects;
            this.Biodata = biodata;
            this.State = state;
            this.City = city;
            this.Address = address;
            this.Status = status;
            this.UserName = userName;
            this.Password = password;
            this.Debit = debit;
            this.TutoringFee = tutoringFee;
            this.ProfileImgLink = profileImgLink;
            this.Dob = dob;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string School { get => school; set => school = value; }
        public string Subjects { get => subjects; set => subjects = value; }
        public string Biodata { get => biodata; set => biodata = value; }
        public string State { get => state; set => state = value; }
        public string City { get => city; set => city = value; }
        public string Address { get => address; set => address = value; }
        public string Status { get => status; set => status = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Debit { get => debit; set => debit = value; }
        public string TutoringFee { get => tutoringFee; set => tutoringFee = value; }
        public string ProfileImgLink { get => profileImgLink; set => profileImgLink = value; }
        public string Dob { get => dob; set => dob = value; }
    }
}