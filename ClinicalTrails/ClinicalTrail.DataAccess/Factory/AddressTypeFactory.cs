using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.DataAccess.Factory
{
    public class AddressTypeFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public AddressTypeFactory()
        {
            _context = new ClinicalTrialsDBEntities();
        }

        public List<AddressType> GetAllAddressTypeList()
        {
            var v = from resp in _context.AddressTypes
                    select resp;
            return v.ToList();
        }

        public AddressType GetAddressTypeByID(string name)
        {
            var v = from resp in _context.AddressTypes
                    where resp.AddressTypeName == name
                    select resp;
            return v.FirstOrDefault();
        }
    }
}
