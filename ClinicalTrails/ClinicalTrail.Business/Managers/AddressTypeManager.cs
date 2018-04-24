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
    public class AddressTypeManager
    {
        private readonly AddressTypeFactory _factory;

        public AddressTypeManager()
        {
            _factory = new AddressTypeFactory();
        }

        public List<AddressTypeDto> GetAddressTypeList()
        {
            return AddressTypeMapper.Map(_factory.GetAllAddressTypeList());
        }

        public AddressTypeDto GetAddressTypeByID(string name)
        {
            return AddressTypeMapper.Map(_factory.GetAddressTypeByID(name));
        }
    }
}
