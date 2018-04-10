using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.DataContract
{
    public class InvestigatorMasterDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Investigator_First_Name { get; set; }
        public string Investigator_Middle_Name { get; set; }
        public string Investigator_Last_Name { get; set; }
        public string Degree { get; set; }
        public string Address_Type { get; set; }
        public string Institute_Name { get; set; }
        public string Street_Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Post_Code { get; set; }
        public string Office_Phone { get; set; }
        public string Mobile_Phone { get; set; }
        public string Fax_No { get; set; }
        public string Email_ID { get; set; }
        public string Primary_Email { get; set; }
        public string Secondary_Email_ID { get; set; }
        public string Certification { get; set; }
        public string Speciality { get; set; }
        public string Centre_1 { get; set; }
        public string Centre_2 { get; set; }
        public string Centre_3 { get; set; }
        public string Payee_Name { get; set; }
        public string Bank_Account_Number { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
