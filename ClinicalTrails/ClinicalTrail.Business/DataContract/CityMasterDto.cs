using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.DataContract
{
    public class CityMasterDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> StateID { get; set; }
    }
}
