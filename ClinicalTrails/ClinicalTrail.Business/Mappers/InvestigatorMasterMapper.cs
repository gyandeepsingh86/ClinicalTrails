using ClinicalTrail.Business.DataContract;
using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Mappers
{
    public class InvestigatorMasterMapper
    {
        public static List<InvestigatorMasterDto> Map(List<InvestigatorMaster> list)
        {
            var v = from resp in list
                    select Map(resp);

            return v.ToList();
        }

        public static List<InvestigatorMaster> Map(List<InvestigatorMasterDto> list)
        {
            var v = from resp in list
                    select Map(resp);

            return v.ToList();
        }

        public static InvestigatorMaster Map(InvestigatorMasterDto investigatormasterdto)
        {
            InvestigatorMaster invertigatormaster = new InvestigatorMaster();
            invertigatormaster.ID = investigatormasterdto.ID;
            invertigatormaster.Title = investigatormasterdto.Title;
            invertigatormaster.Investigator_First_Name = investigatormasterdto.Investigator_First_Name;
            invertigatormaster.Investigator_Middle_Name = investigatormasterdto.Investigator_Middle_Name;
            invertigatormaster.Investigator_Last_Name = investigatormasterdto.Investigator_Last_Name;
            invertigatormaster.Degree = investigatormasterdto.Degree;
            invertigatormaster.Address_Type = investigatormasterdto.Address_Type;
            invertigatormaster.Institute_Name = investigatormasterdto.Institute_Name;
            invertigatormaster.Street_Address = investigatormasterdto.Street_Address;
            invertigatormaster.City = investigatormasterdto.City;
            invertigatormaster.State = investigatormasterdto.State;
            invertigatormaster.Country = investigatormasterdto.Country;
            invertigatormaster.Post_Code = investigatormasterdto.Post_Code;
            invertigatormaster.Office_Phone = investigatormasterdto.Office_Phone;
            invertigatormaster.Mobile_Phone = investigatormasterdto.Mobile_Phone;
            invertigatormaster.Fax_No = investigatormasterdto.Fax_No;
            invertigatormaster.Email_ID = investigatormasterdto.Email_ID;
            invertigatormaster.Primary_Email = investigatormasterdto.Primary_Email;
            invertigatormaster.Secondary_Email_ID = investigatormasterdto.Secondary_Email_ID;
            invertigatormaster.Certification = investigatormasterdto.Certification;
            invertigatormaster.Speciality = investigatormasterdto.Speciality;
            invertigatormaster.Centre_1 = investigatormasterdto.Centre_1;
            invertigatormaster.Centre_2 = investigatormasterdto.Centre_2;
            invertigatormaster.Centre_3 = investigatormasterdto.Centre_3;
            invertigatormaster.Payee_Name = investigatormasterdto.Payee_Name;
            invertigatormaster.Bank_Account_Number = investigatormasterdto.Bank_Account_Number;
            invertigatormaster.IsActive = investigatormasterdto.IsActive;

            return invertigatormaster;
        }

        public static InvestigatorMasterDto Map(InvestigatorMaster investigatormaster)
        {
            InvestigatorMasterDto invertigatormasterdto = new InvestigatorMasterDto();
            invertigatormasterdto.ID = investigatormaster.ID;
            invertigatormasterdto.Title = investigatormaster.Title;
            invertigatormasterdto.Investigator_First_Name = investigatormaster.Investigator_First_Name;
            invertigatormasterdto.Investigator_Middle_Name = investigatormaster.Investigator_Middle_Name;
            invertigatormasterdto.Investigator_Last_Name = investigatormaster.Investigator_Last_Name;
            invertigatormasterdto.Degree = investigatormaster.Degree;
            invertigatormasterdto.Address_Type = investigatormaster.Address_Type;
            invertigatormasterdto.Institute_Name = investigatormaster.Institute_Name;
            invertigatormasterdto.Street_Address = investigatormaster.Street_Address;
            invertigatormasterdto.City = investigatormaster.City;
            invertigatormasterdto.State = investigatormaster.State;
            invertigatormasterdto.Country = investigatormaster.Country;
            invertigatormasterdto.Post_Code = investigatormaster.Post_Code;
            invertigatormasterdto.Office_Phone = investigatormaster.Office_Phone;
            invertigatormasterdto.Mobile_Phone = investigatormaster.Mobile_Phone;
            invertigatormasterdto.Fax_No = investigatormaster.Fax_No;
            invertigatormasterdto.Email_ID = investigatormaster.Email_ID;
            invertigatormasterdto.Primary_Email = investigatormaster.Primary_Email;
            invertigatormasterdto.Secondary_Email_ID = investigatormaster.Secondary_Email_ID;
            invertigatormasterdto.Certification = investigatormaster.Certification;
            invertigatormasterdto.Speciality = investigatormaster.Speciality;
            invertigatormasterdto.Centre_1 = investigatormaster.Centre_1;
            invertigatormasterdto.Centre_2 = investigatormaster.Centre_2;
            invertigatormasterdto.Centre_3 = investigatormaster.Centre_3;
            invertigatormasterdto.Payee_Name = investigatormaster.Payee_Name;
            invertigatormasterdto.Bank_Account_Number = investigatormaster.Bank_Account_Number;
            invertigatormasterdto.IsActive = investigatormaster.IsActive;

            return invertigatormasterdto;
        }
    }
}
