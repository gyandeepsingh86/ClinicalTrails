using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Mapper
{
    public class VendorMasterModelMapper
    {
        internal static List<VendorMasterModel> Map(List<VendorMasterDto> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static List<VendorMasterDto> Map(List<VendorMasterModel> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static VendorMasterModel Map(VendorMasterDto source)
        {
            var to = new VendorMasterModel();

            to.Bank_Account_Number = source.Bank_Account_Number;
            to.Vendor_Name = source.Vendor_Name;
            to.Vendor_No = source.Vendor_No;
            to.Vendor_Type = source.Vendor_Type;
            to.City = source.City;
            to.Country = source.Country;
            to.Email = source.Email;
            to.Equipments = source.Equipments;
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
            to.IsActive = source.IsActive;

            return to;
        }

        internal static VendorMasterDto Map(VendorMasterModel source)
        {
            var to = new VendorMasterDto();

            to.Bank_Account_Number = source.Bank_Account_Number;
            to.Vendor_No = source.Vendor_No;
            to.Vendor_Name = source.Vendor_Name;
            to.Vendor_Type = source.Vendor_Type;
            to.City = source.City;
            to.Country = source.Country;
            to.Email = source.Email;
            to.Equipments = source.Equipments;
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
            to.IsActive = source.IsActive;

            return to;
        }
    }
}