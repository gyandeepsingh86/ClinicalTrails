using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.DataContract
{
    public class UserRegistrationDto
    {
        public int RegisterID { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string SecondaryEmail { get; set; }
        public System.DateTime JoiningDate { get; set; }
        public string MobileNumber { get; set; }
        public string OfficeNumber { get; set; }
        public string FaxNumber { get; set; }
        public string StreetAddress { get; set; }
        public string PinCode { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public string Country { get; set; }
    }
}
