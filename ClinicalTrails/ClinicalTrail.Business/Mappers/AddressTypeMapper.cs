using ClinicalTrail.Business.DataContract;
using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Mappers
{
    public class AddressTypeMapper
    {
        public static List<AddressType> Map(List<AddressTypeDto> addreddtypelist)
        {
            var v = from resp in addreddtypelist
                    select Map(resp);

            return v.ToList();
        }

        public static List<AddressTypeDto> Map(List<AddressType> addreddtypelist)
        {
            var v = from resp in addreddtypelist
                    select Map(resp);

            return v.ToList();
        }

        public static AddressType Map(AddressTypeDto resp)
        {
            AddressType at = new AddressType();
            at.AddressTypeID = resp.AddressTypeID;
            at.AddressTypeName = resp.AddressTypeName;

            return at;
        }

        public static AddressTypeDto Map(AddressType resp)
        {
            AddressTypeDto atdto = new AddressTypeDto();
            atdto.AddressTypeID = resp.AddressTypeID;
            atdto.AddressTypeName = resp.AddressTypeName;

            return atdto;
        }
    }
}
