using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.GeneralObjectStore.ErrorHandler
{
    public static class ErrorHandler
    {
        public static Exception HandleException(Exception ex, ILogger log, string userdetails)
        {
            //string languageCode = "en";

            //if (ex.GetType() == typeof(Exception))
            //{
            //    Exception extype = (Exception)ex;
            //    List<string> msgs = GetStrings(log, extype.InnerException, languageCode);
            //    throw new Exception<ClinicalTrailFaultClient>(new ClinicalTrailFaultClient(msgs), new FaultReason("client"));
            //}
            //else
            //{
            //    log.Error(ex.Message, ex);
            //    string reas = GetString(logger, ClientExceptionCodes.GenericServerError, languageCode) + "<br/>" + GetString(logger, ClientExceptionCodes.ServerTime, languageCode, DateTime.Now.ToString());
            //    throw new FaultException<ClinicalTrailFaultContract>(new ClinicalTrailFaultContract(operationContract + ex.Message), new FaultReason(reas));
            //    ;
            //}

            //Temp
            return null;
        }

        private static List<string> GetStrings(ILogger log, Exception exception, string languageCode)
        {
            //List<string> res = new List<string>();
            //foreach (Exception err in exception)
            //{
            //        res.Add(GetString(log, err.Data, err.HResult, err.InnerException, languageCode, err.Message,err.Source,err.TargetSite));
            //}
            //return res;

            //Team
            return null;
        }

        private static string GetString(ILogger log, System.Collections.IDictionary dictionary, int p1, Exception exception, string languageCode, string p2, string p3, System.Reflection.MethodBase methodBase)
        {
            //try
            //{
            //    //TranslationManager tm = new TranslationManager();
            //    string s = "";
            //    //s = tm.GetTranslation(languageCode, key.GetHashCode());
            //    //s = System.Web.HttpUtility.HtmlDecode(s);
            //    if (!string.IsNullOrEmpty(s))
            //    {
            //        string[] newPars = new string[pars.Length + 1];

            //        int parsIndex = 0;
            //        bool keyParamInserted = false;

            //        for (int i = 0; i < newPars.Length; i++)
            //        {
            //            if (!keyParamInserted && i == keyParamIndex)
            //            {
            //                keyParamInserted = true;
            //                //newPars[i] = tm.GetTranslation(languageCode, keyParameterID.GetHashCode());
            //            }
            //            else
            //            {
            //                newPars[i] = pars[parsIndex];
            //                parsIndex += 1;
            //            }
            //        }

            //        s = string.Format(s, newPars);
            //    }

            //    return s;
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.Message, ex);
            //    return "Unexpected error during error handling (retrieving translations from database)!";
            //}
            //Temp
            return null;
        }
    }
}
