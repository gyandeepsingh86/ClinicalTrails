using ClinicalTrail.Business.DataContract;
using ClinicalTrail.Business.Mappers;
using ClinicalTrail.DataAccess.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Managers
{
    public class UserRegistrationManager
    {
        private readonly UserRegistrationFactory _userregistrationfactory;

        public UserRegistrationManager()
        {
            _userregistrationfactory = new UserRegistrationFactory();
        }

        public List<UserRegistrationDto> GetAllRegisteredUserList()
        {
            return UserRegistrationMapper.Map(_userregistrationfactory.GetAllRegisteredUserList());
        }

        public void AddRegisteredUser(UserRegistrationDto newuser)
        {
            _userregistrationfactory.AddRegisteredUser(UserRegistrationMapper.Map(newuser));
        }

        public UserRegistrationDto GetRegisteredUserByID(int userid)
        {
            return UserRegistrationMapper.Map(_userregistrationfactory.GetRegisteredUserByID(userid));
        }

        public List<UserRegistrationDto> FilterUserRegistration(UserRegistrationDto newuser)
        {
            return UserRegistrationMapper.Map(_userregistrationfactory.FilterUserRegistration(UserRegistrationMapper.Map(newuser)));
        }

        public bool DeleteUserRegistration(int centno)
        {
            return _userregistrationfactory.DeleteUserRegistration(centno);
        }

        //public void AddCenterManager(List<CenterMasterDto> list)
        //{
        //    foreach (CenterMasterDto dto in list)
        //    {
        //        _userregistrationfactory.AddCenterManager(CenterMasterMapper.Map(dto));
        //    }
        //}
    }
}
