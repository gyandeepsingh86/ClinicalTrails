using ClinicalTrail.Business.DataContract;
using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Mappers
{
    public class UserRegistrationMapper
    {
        internal static List<UserRegistrationDto> Map(List<UserRegistration> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static List<UserRegistrationDto> Map(IQueryable<UserRegistration> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static UserRegistrationDto Map(UserRegistration source)
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

        internal static UserRegistration Map(UserRegistrationDto source)
        {
            var to = new UserRegistration();

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
