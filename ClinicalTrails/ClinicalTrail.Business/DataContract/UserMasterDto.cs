using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.DataContract
{
    public class UserMasterDto
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string DOB { get; set; }
        public System.DateTime Joining_Date { get; set; }
        public int Address_ID { get; set; }
        public int Contact_ID { get; set; }
        public System.DateTime Last_Login_Time { get; set; }
        public bool IsLoggedOut { get; set; }
        public string UserType { get; set; }
        public string UserPageAccess { get; set; }
    }
}
