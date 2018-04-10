using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Mapper
{
    public class InvestigatorMasterModelMapper
    {
        public static List<InvestigatorMasterDto> Map(List<InvestigatorMasterModel> list)
        {
            var v = from resp in list
                    select Map(resp);

            return v.ToList();
        }

        public static List<InvestigatorMasterModel> Map(List<InvestigatorMasterDto> list)
        {
            var v = from resp in list
                    select Map(resp);

            return v.ToList();
        }

        public static InvestigatorMasterModel Map(InvestigatorMasterDto investigatormasterdto)
        {
            InvestigatorMasterModel invertigatormastermodel = new InvestigatorMasterModel();
            invertigatormastermodel.ID = investigatormasterdto.ID;
            invertigatormastermodel.Title = investigatormasterdto.Title;
            invertigatormastermodel.Investigator_First_Name = investigatormasterdto.Investigator_First_Name;
            invertigatormastermodel.Investigator_Middle_Name = investigatormasterdto.Investigator_Middle_Name;
            invertigatormastermodel.Investigator_Last_Name = investigatormasterdto.Investigator_Last_Name;
            invertigatormastermodel.Degree = investigatormasterdto.Degree;
            invertigatormastermodel.Address_Type = investigatormasterdto.Address_Type;
            invertigatormastermodel.Institute_Name = investigatormasterdto.Institute_Name;
            invertigatormastermodel.Street_Address = investigatormasterdto.Street_Address;
            invertigatormastermodel.City = investigatormasterdto.City;
            invertigatormastermodel.State = investigatormasterdto.State;
            invertigatormastermodel.Country = investigatormasterdto.Country;
            invertigatormastermodel.Post_Code = investigatormasterdto.Post_Code;
            invertigatormastermodel.Office_Phone = investigatormasterdto.Office_Phone;
            invertigatormastermodel.Mobile_Phone = investigatormasterdto.Mobile_Phone;
            invertigatormastermodel.Fax_No = investigatormasterdto.Fax_No;
            invertigatormastermodel.Email_ID = investigatormasterdto.Email_ID;
            invertigatormastermodel.Primary_Email = investigatormasterdto.Primary_Email;
            invertigatormastermodel.Secondary_Email_ID = investigatormasterdto.Secondary_Email_ID;
            invertigatormastermodel.Certification = investigatormasterdto.Certification;
            invertigatormastermodel.Speciality = investigatormasterdto.Speciality;
            invertigatormastermodel.Centre_1 = investigatormasterdto.Centre_1;
            invertigatormastermodel.Centre_2 = investigatormasterdto.Centre_2;
            invertigatormastermodel.Centre_3 = investigatormasterdto.Centre_3;
            invertigatormastermodel.Payee_Name = investigatormasterdto.Payee_Name;
            invertigatormastermodel.Bank_Account_Number = investigatormasterdto.Bank_Account_Number;
            invertigatormastermodel.IsActive = investigatormasterdto.IsActive;

            return invertigatormastermodel;
        }

        public static InvestigatorMasterDto Map(InvestigatorMasterModel investigatormastermodel)
        {
            InvestigatorMasterDto invertigatormasterdto = new InvestigatorMasterDto();
            invertigatormasterdto.ID = investigatormastermodel.ID;
            invertigatormasterdto.Title = investigatormastermodel.Title;
            invertigatormasterdto.Investigator_First_Name = investigatormastermodel.Investigator_First_Name;
            invertigatormasterdto.Investigator_Middle_Name = investigatormastermodel.Investigator_Middle_Name;
            invertigatormasterdto.Investigator_Last_Name = investigatormastermodel.Investigator_Last_Name;
            invertigatormasterdto.Degree = investigatormastermodel.Degree;
            invertigatormasterdto.Address_Type = investigatormastermodel.Address_Type;
            invertigatormasterdto.Institute_Name = investigatormastermodel.Institute_Name;
            invertigatormasterdto.Street_Address = investigatormastermodel.Street_Address;
            invertigatormasterdto.City = investigatormastermodel.City;
            invertigatormasterdto.State = investigatormastermodel.State;
            invertigatormasterdto.Country = investigatormastermodel.Country;
            invertigatormasterdto.Post_Code = investigatormastermodel.Post_Code;
            invertigatormasterdto.Office_Phone = investigatormastermodel.Office_Phone;
            invertigatormasterdto.Mobile_Phone = investigatormastermodel.Mobile_Phone;
            invertigatormasterdto.Fax_No = investigatormastermodel.Fax_No;
            invertigatormasterdto.Email_ID = investigatormastermodel.Email_ID;
            invertigatormasterdto.Primary_Email = investigatormastermodel.Primary_Email;
            invertigatormasterdto.Secondary_Email_ID = investigatormastermodel.Secondary_Email_ID;
            invertigatormasterdto.Certification = investigatormastermodel.Certification;
            invertigatormasterdto.Speciality = investigatormastermodel.Speciality;
            invertigatormasterdto.Centre_1 = investigatormastermodel.Centre_1;
            invertigatormasterdto.Centre_2 = investigatormastermodel.Centre_2;
            invertigatormasterdto.Centre_3 = investigatormastermodel.Centre_3;
            invertigatormasterdto.Payee_Name = investigatormastermodel.Payee_Name;
            invertigatormasterdto.Bank_Account_Number = investigatormastermodel.Bank_Account_Number;
            invertigatormasterdto.IsActive = investigatormastermodel.IsActive;

            return invertigatormasterdto;
        }
    }
}