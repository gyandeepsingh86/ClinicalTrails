using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.DataAccess.Factory
{
    public class UserRegistrationFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public UserRegistrationFactory()
        {
            _context = new ClinicalTrialsDBEntities();
        }

        public List<UserRegistration> GetAllRegisteredUserList()
        {
            var v = from resp in _context.UserRegistrations
                    select resp;
            return v.ToList();
        }

        public UserRegistration GetRegisteredUserByID(int registeredid)
        {
            var v = from resp in _context.UserRegistrations
                    where resp.RegisterID == registeredid
                    select resp;
            return v.FirstOrDefault();
        }

        public void AddRegisteredUser(UserRegistration newuser)
        {
            if (!string.IsNullOrEmpty(newuser.RegisterID.ToString()))
            {
                var result = (from resp in _context.UserRegistrations
                              where resp.RegisterID == newuser.RegisterID
                              select resp).FirstOrDefault();

                result.City = newuser.City;
                result.Country = newuser.Country;
                result.Email = newuser.Email;
                result.DOB = newuser.DOB;
                result.FaxNumber = newuser.FaxNumber;
                result.FirstName = newuser.FirstName;
                result.Gender= newuser.Gender;
                result.JoiningDate = newuser.JoiningDate;
                result.LastName = newuser.LastName;
                result.MiddleName = newuser.MiddleName;
                result.MobileNumber = newuser.MobileNumber;
                result.OfficeNumber = newuser.OfficeNumber;
                result.PinCode= newuser.PinCode;
                result.SecondaryEmail = newuser.SecondaryEmail;
                result.state = newuser.state;
                result.StreetAddress= newuser.StreetAddress;
                result.Title = newuser.Title;
                result.UserName = newuser.UserName;
            }
            else
                _context.UserRegistrations.Add(newuser);

            _context.SaveChanges();
        }

        public List<UserRegistration> FilterUserRegistration(UserRegistration list)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserRegistration(int centno)
        {
            throw new NotImplementedException();
        }
    }
}
