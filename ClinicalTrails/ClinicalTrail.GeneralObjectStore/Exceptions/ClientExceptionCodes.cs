using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.GeneralObjectStore.Exceptions
{

    /// <summary>
    /// enumeration that contains all the possible error messages a consumer needs/wants to see
    /// the key (numbers) are used to fetch the correct translated message from the database.
    /// </summary>
    public enum ClientExceptionCodes
    {
        /// <summary>
        /// Error that is shown to user in case of unexpected problems
        /// A generic message is shown to contact the administrator
        /// Everything should be logged in this case.
        /// </summary>
        GenericServerError = 10000,
        ServerTime = 10001,


    }
}
