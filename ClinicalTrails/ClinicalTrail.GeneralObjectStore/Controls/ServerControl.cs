using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.GeneralObjectStore.Controls
{
    public static class ServerControl
    {
        public static string GetCurentDatetime()
        {
            return System.DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }
    }
}
