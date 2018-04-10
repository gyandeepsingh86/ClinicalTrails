using ClinicalTrail.Application.WebApplication.Mapper;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Manager
{
    public class AddressTypeModelManager
    {
        private readonly AddressTypeManager _manager;

        public AddressTypeModelManager()
        {
            _manager = new AddressTypeManager();
        }
        public List<AddressTypeModel> GetAddressTypeList()
        {
            return AddressTypeModelMapper.Map(_manager.GetAddressTypeList());
        }
    }
}