using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.GeneralObjectStore.Logger
{
    public interface IAmLoggable
    {
        string ToLogString();
    }
}
