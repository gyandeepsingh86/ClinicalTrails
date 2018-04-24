using ClinicalTrail.Business.DataContract;
using ClinicalTrail.Business.Managers;
using ClinicalTrail.DataAccess.Factory;
using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Mappers
{
    public class CenterMasterMapper
    {
        internal static List<CenterMasterDto> Map(List<CenterMaster> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static List<CenterMasterDto> Map(IQueryable<CenterMaster> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static CenterMasterDto Map(CenterMaster source)
        {
            var to = new CenterMasterDto();

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

        internal static CenterMaster Map(CenterMasterDto source)
        {
            var to = new CenterMaster();

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

        internal static CenterMasterDto Map(int CentNo)
        {
            var to = new CenterMasterDto();
            to.Center_No = CentNo;
            return to;
        }
    }
}
