using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.GeneralObjectStore.Enums
{
    [DataContract]
    public enum DataSources
    {
        [EnumMember]
        SQLServer = 0,
        [EnumMember]
        ORACLE = 1,
        [EnumMember]
        MYSQL = 2,
        [EnumMember]
        SCALA = 1,
    }
}
