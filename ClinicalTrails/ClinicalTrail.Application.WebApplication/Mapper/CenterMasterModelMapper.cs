using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Mapper
{
    public class CenterMasterModelMapper
    {
        internal static List<CenterMasterModel> Map(List<CenterMasterDto> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static List<CenterMasterDto> Map(List<CenterMasterModel> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static CenterMasterModel Map(CenterMasterDto source)
        {
            var to = new CenterMasterModel();

            to.Bank_Account_Number = source.Bank_Account_Number;
            to.Center_Name = source.Center_Name;
            to.Center_No = source.Center_No;
            to.Center_Type = source.Center_Type;
            to.City = source.City;
            to.Country = source.Country;
            to.Email = source.Email;
            to.Equipments = source.Equipments;
            to.Investigator_1 = source.Investigator_1;
            to.Investigator_2 = source.Investigator_2;
            to.Investigator_3 = source.Investigator_3;
            to.Mobile_Phone = source.Mobile_Phone;
            to.Office_Phone = source.Office_Phone;
            to.Payee_Name = source.Payee_Name;
            to.Post_code = source.Post_code;
            to.Primary_Email = source.Primary_Email;
            to.Secondary_Email = source.Secondary_Email;
            to.Specialties = source.Specialties;
            to.State = source.State;
            to.Street_Address = source.Street_Address;
            to.Website = source.Website;

            return to;
        }

        internal static CenterMasterDto Map(CenterMasterModel source)
        {
            var to = new CenterMasterDto();

            to.Bank_Account_Number = source.Bank_Account_Number;
            to.Center_No = source.Center_No;
            to.Center_Name = source.Center_Name;
            to.Center_Type = source.Center_Type;
            to.City = source.City;
            to.Country = source.Country;
            to.Email = source.Email;
            to.Equipments = source.Equipments;
            to.Investigator_1 = source.Investigator_1;
            to.Investigator_2 = source.Investigator_2;
            to.Investigator_3 = source.Investigator_3;
            to.Mobile_Phone = source.Mobile_Phone;
            to.Office_Phone = source.Office_Phone;
            to.Payee_Name = source.Payee_Name;
            to.Post_code = source.Post_code;
            to.Primary_Email = source.Primary_Email;
            to.Secondary_Email = source.Secondary_Email;
            to.Specialties = source.Specialties;
            to.State = source.State;
            to.Street_Address = source.Street_Address;
            to.Website = source.Website;

            return to;
        }
    }
}