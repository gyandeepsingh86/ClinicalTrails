using AtlasCopco.Framework.Objects.Logging;
using ClinicalTrail.GeneralObjectStore.Exceptions;
using ClinicalTrail.Services.FaultContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Services.ServiceImplementation
{
    public class Error
    {
        /// <summary>
        /// if exception is a clientexception then we throw the appropriate message to the clients
        /// if it is not a clientexception we give back a generic message and log the information
        /// </summary>
        /// <param name="ex">exception that was thrown</param>
        /// <param name="logger">logger object to be able to log the information</param>
        /// <param name="user">user information</param>
        /// <param name="operationContract">from which webmethod this is being called</param>
        /// <returns></returns>
        public static FaultException HandleException(Exception ex, ILogger logger, string operationContract)
        {
            string languageCode = "en";
            //if (user == null || string.IsNullOrEmpty(user.Language))
            //    languageCode = "en";
            //else
            //    languageCode = user.Language;

            if (ex.GetType() == typeof(ClientException))
            {
                ClientException cEx = (ClientException)ex;
                List<string> msgs = GetStrings(logger, cEx.Errors, languageCode);
                throw new FaultException<ClinicalTrailFaultClient>(new ClinicalTrailFaultClient(msgs), new FaultReason("client"));
            }
            else
            {
                logger.Error(ex.Message, ex);
                string reas = GetString(logger, ClientExceptionCodes.GenericServerError, languageCode) + "<br/>" + GetString(logger, ClientExceptionCodes.ServerTime, languageCode, DateTime.Now.ToString());
                throw new FaultException<ClinicalTrailFaultContract>(new ClinicalTrailFaultContract(operationContract + ex.Message), new FaultReason(reas));
                ;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="errors"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        private static List<string> GetStrings(ILogger logger, List<ClientExceptionError> errors, string languageCode)
        {
            List<string> res = new List<string>();
            foreach (ClientExceptionError err in errors)
            {
                if (err.KeyParameterID != 0)
                {
                    res.Add(GetString(logger, err.ExceptionID, err.KeyParameterID, err.KeyParamIndex, languageCode, err.Parameters));
                }
                else
                {
                    res.Add(GetString(logger, err.ExceptionID, languageCode, err.Parameters));
                }

            }
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="key"></param>
        /// <param name="languageCode"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        private static string GetString(ILogger logger, ClientExceptionCodes key, string languageCode, params string[] pars)
        {
            try
            {
                //TranslationManager tm = new TranslationManager();
                string s = "";
                //s = tm.GetTranslation(languageCode, key.GetHashCode());
                //s = System.Web.HttpUtility.HtmlDecode(s);
                if (!string.IsNullOrEmpty(s))
                    s = string.Format(s, pars);

                return s;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                return "Unexpected error during error handling (retrieving translations from database)!";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="key"></param>
        /// <param name="keyParameterID"></param>
        /// <param name="keyParamIndex"></param>
        /// <param name="languageCode"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        private static string GetString(ILogger logger, ClientExceptionCodes key, ClientExceptionCodes keyParameterID, int keyParamIndex, string languageCode, params string[] pars)
        {
            try
            {
                //TranslationManager tm = new TranslationManager();
                string s = "";
                //s = tm.GetTranslation(languageCode, key.GetHashCode());
                //s = System.Web.HttpUtility.HtmlDecode(s);
                if (!string.IsNullOrEmpty(s))
                {
                    string[] newPars = new string[pars.Length + 1];

                    int parsIndex = 0;
                    bool keyParamInserted = false;

                    for (int i = 0; i < newPars.Length; i++)
                    {
                        if (!keyParamInserted && i == keyParamIndex)
                        {
                            keyParamInserted = true;
                            //newPars[i] = tm.GetTranslation(languageCode, keyParameterID.GetHashCode());
                        }
                        else
                        {
                            newPars[i] = pars[parsIndex];
                            parsIndex += 1;
                        }
                    }

                    s = string.Format(s, newPars);
                }

                return s;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                return "Unexpected error during error handling (retrieving translations from database)!";
            }
        }
    }
}
