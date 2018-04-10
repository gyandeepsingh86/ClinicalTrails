using ClinicalTrail.GeneralObjectStore.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Interfaces
{
    public interface ILogManager
    {
        ILogger GetLogger();
    }
}
