using ClinicalTrail.Application.WebApplication.ClinicalTrailServiceReferance;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Mapper
{
    public class CityMasterModelMapper
    {
        public static List<CityMasterModel> Map(List<CityMasterDto> citymasterlist)
        {
            var cm = from c in citymasterlist
                     select Map(c);

            return cm.ToList();
        }

        public static List<CityMasterDto> Map(List<CityMasterModel> citymasterlist)
        {
            var cm = from c in citymasterlist
                     select Map(c);

            return cm.ToList();
        }

        public static CityMasterDto Map(CityMasterModel citymastermodel)
        {
            CityMasterDto citymasterdto = new CityMasterDto();

            citymasterdto.ID = citymastermodel.ID;
            citymasterdto.Name = citymastermodel.Name;
            citymasterdto.StateID = citymastermodel.StateID;

            return citymasterdto;
        }

        public static CityMasterModel Map(CityMasterDto citymaster)
        {
            CityMasterModel citymastermodel = new CityMasterModel();

            citymastermodel.ID = citymaster.ID;
            citymastermodel.Name = citymaster.Name;
            citymastermodel.StateID = citymaster.StateID;

            return citymastermodel;
        }

        internal static CityMasterModel Map(GetAllState_Response response)
        {
            CityMasterModel citymastermodel = new CityMasterModel();

            citymastermodel.ID = response.ID;
            citymastermodel.Name = response.Name;
            citymastermodel.StateID = response.StateId;

            return citymastermodel;
        }
    }
}