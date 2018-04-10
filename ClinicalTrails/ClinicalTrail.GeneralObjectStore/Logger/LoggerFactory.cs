using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ClinicalTrail.GeneralObjectStore.Logger
{
    public static class LoggerFactory
    {
        /// <summary>
        /// creates the logger
        /// </summary>
        /// <returns></returns>
        public static ILogger CreateLogger()
        {
            Type t = Type.GetType(ConfigurationManager.AppSettings["logger"], true, true);
            return (ILogger)Activator.CreateInstance(t);
        }
    }
}
