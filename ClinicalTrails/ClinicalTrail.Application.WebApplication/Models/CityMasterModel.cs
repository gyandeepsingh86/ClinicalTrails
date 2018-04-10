using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Models
{
    public class CityMasterModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? StateID { get; set; }
    }
}