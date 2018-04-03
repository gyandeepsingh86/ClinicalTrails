using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.GeneralObjectStore.Exceptions
{

    /// <summary>
    /// custom exception to be able to bring back appropriate, translated messaged to the consumers of the 
    /// WCF service.
    /// </summary>
    public class ClientException : ApplicationException
    {
        public ClientException(List<ClientExceptionError> errors)
        {
            Errors = errors;
        }
        public List<ClientExceptionError> Errors { get; set; }
    }

    public class ClientExceptionError
    {
        public ClientExceptionError(ClientExceptionCodes excID, params string[] parameters)
        {
            ExceptionID = excID;
            Parameters = parameters;
            KeyParameterID = 0;
            KeyParamIndex = -1;
        }
        public ClientExceptionError(ClientExceptionCodes excID, ClientExceptionCodes keyparam, int keyParamIndex, params string[] parameters)
        {
            ExceptionID = excID;
            Parameters = parameters;
            KeyParamIndex = keyParamIndex;

            if (keyparam != null)
            {
                KeyParameterID = keyparam;
                KeyParamIndex = KeyParamIndex;
            }
            else
            {
                KeyParameterID = 0;
                KeyParamIndex = -1;
            }
        }
        public ClientExceptionCodes ExceptionID { get; set; }
        public ClientExceptionCodes KeyParameterID { get; set; }
        public int KeyParamIndex { get; set; }
        public string[] Parameters { get; set; }
    }
}
