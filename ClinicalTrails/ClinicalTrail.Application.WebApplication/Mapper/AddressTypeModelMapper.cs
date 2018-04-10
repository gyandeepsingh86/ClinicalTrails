using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Mapper
{
    public class AddressTypeModelMapper
    {
        internal static List<AddressTypeModel> Map(List<AddressTypeDto> list)
        {
            var v = from resp in list
                    select Map(resp);

            return v.ToList();
        }

        internal static AddressTypeModel Map(AddressTypeDto resp)
        {
            AddressTypeModel atm = new AddressTypeModel();
            atm.AddressTypeID = resp.AddressTypeID;
            atm.AddressTypeName = resp.AddressTypeName;

            return atm;
        }
    }
}