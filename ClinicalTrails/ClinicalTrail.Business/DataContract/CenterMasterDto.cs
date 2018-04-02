using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.DataContract
{
    public class CenterMasterDto
    {
        public int Center_No { get; set; }
        public string Center_Name { get; set; }
        public string Center_Type { get; set; }
        public string Street_Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Post_code { get; set; }
        public string Specialties { get; set; }
        public string Office_Phone { get; set; }
        public string Mobile_Phone { get; set; }
        public string Email { get; set; }
        public string Primary_Email { get; set; }
        public string Secondary_Email { get; set; }
        public string Website { get; set; }
        public string Equipments { get; set; }
        public string Investigator_1 { get; set; }
        public string Investigator_2 { get; set; }
        public string Investigator_3 { get; set; }
        public string Payee_Name { get; set; }
        public string Bank_Account_Number { get; set; }
    }
}
