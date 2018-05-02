using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Mapper
{
    public class UserRegistrationModelMapper
    {
        internal static List<UserRegistrationModel> Map(List<UserRegistrationDto> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static List<UserRegistrationModel> Map(IQueryable<UserRegistrationDto> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static UserRegistrationModel Map(UserRegistrationDto source)
        {
            var to = new UserRegistrationModel();

            to.RegisterID = source.RegisterID;
            to.City = source.City;
            to.Country = source.Country;
            to.Email = source.Email;
            to.DOB = source.DOB;
            to.FaxNumber = source.FaxNumber;
            to.FirstName = source.FirstName;
            to.Gender = source.Gender;
            to.JoiningDate = source.JoiningDate;
            to.LastName = source.LastName;
            to.MiddleName = source.MiddleName;
            to.MobileNumber = source.MobileNumber;
            to.OfficeNumber = source.OfficeNumber;
            to.PinCode = source.PinCode;
            to.SecondaryEmail = source.SecondaryEmail;
            to.state = source.state;
            to.StreetAddress = source.StreetAddress;
            to.Title = source.Title;
            to.UserName = source.UserName;

            return to;
        }

        internal static UserRegistrationDto Map(UserRegistrationModel source)
        {
            var to = new UserRegistrationDto();

            to.RegisterID = source.RegisterID;
            to.City = source.City;
            to.Country = source.Country;
            to.Email = source.Email;
            to.DOB = source.DOB;
            to.FaxNumber = source.FaxNumber;
            to.FirstName = source.FirstName;
            to.Gender = source.Gender;
            to.JoiningDate = source.JoiningDate;
            to.LastName = source.LastName;
            to.MiddleName = source.MiddleName;
            to.MobileNumber = source.MobileNumber;
            to.OfficeNumber = source.OfficeNumber;
            to.PinCode = source.PinCode;
            to.SecondaryEmail = source.SecondaryEmail;
            to.state = source.state;
            to.StreetAddress = source.StreetAddress;
            to.Title = source.Title;
            to.UserName = source.UserName;

            return to;
        }
    }
}