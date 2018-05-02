using ClinicalTrail.Business.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Interfaces
{
    public interface IUserRegistration
    {
        void AddNewUserRegistration(UserRegistrationDto newuser);

        UserRegistrationDto GetAllUserRegistered();
    }
}
