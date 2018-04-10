using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicalTrail.DataAccess.Model;

namespace ClinicalTrail.DataAccess.Factory
{
    public class InvestigatorMasterFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public InvestigatorMasterFactory(ClinicalTrialsDBEntities entities)
        {
            _context = entities;
        }

        public InvestigatorMasterFactory()
        {
            _context = new ClinicalTrialsDBEntities();
        }

        public List<InvestigatorMaster> GetAllInvestigatorMasterList()
        {
            var v = from resp in _context.InvestigatorMasters
                    where resp.IsActive != false
                    select resp;

            return v.ToList();
        }

        public InvestigatorMaster GetInvestigatorMasterByID(int id)
        {
            var v = (from resp in _context.InvestigatorMasters
                    where resp.IsActive != false
                    && resp.ID == id
                    select resp).FirstOrDefault();

            return v;
        }

        public void CRUDInvestigatorMaster(InvestigatorMaster investigatormaster, string mode)
        {
            if (!string.IsNullOrEmpty(investigatormaster.ID.ToString()) && investigatormaster.ID != 0)
            {
                var investmaster = (from resp in _context.InvestigatorMasters
                                    where resp.ID == investigatormaster.ID
                                    select resp).FirstOrDefault();



                investmaster.Title = investigatormaster.Title;
                investmaster.Investigator_First_Name = investigatormaster.Investigator_First_Name;
                investmaster.Investigator_Middle_Name = investigatormaster.Investigator_Middle_Name;
                investmaster.Investigator_Last_Name = investigatormaster.Investigator_Last_Name;
                investmaster.Degree = investigatormaster.Degree;
                investmaster.Address_Type = investigatormaster.Address_Type;
                investmaster.Institute_Name = investigatormaster.Institute_Name;
                investmaster.Street_Address = investigatormaster.Street_Address;
                investmaster.City = investigatormaster.City;
                investmaster.State = investigatormaster.State;
                investmaster.Country = investigatormaster.Country;
                investmaster.Post_Code = investigatormaster.Post_Code;
                investmaster.Office_Phone = investigatormaster.Office_Phone;
                investmaster.Mobile_Phone = investigatormaster.Mobile_Phone;
                investmaster.Fax_No = investigatormaster.Fax_No;
                investmaster.Email_ID = investigatormaster.Email_ID;
                investmaster.Primary_Email = investigatormaster.Primary_Email;
                investmaster.Secondary_Email_ID = investigatormaster.Secondary_Email_ID;
                investmaster.Certification = investigatormaster.Certification;
                investmaster.Speciality = investigatormaster.Speciality;
                investmaster.Centre_1 = investigatormaster.Centre_1;
                investmaster.Centre_2 = investigatormaster.Centre_2;
                investmaster.Centre_3 = investigatormaster.Centre_3;
                investmaster.Payee_Name = investigatormaster.Payee_Name;
                investmaster.Bank_Account_Number = investigatormaster.Bank_Account_Number;

                if (mode.ToLower() == "Update")
                    investmaster.IsActive = investigatormaster.IsActive;
                if (mode.ToLower() == "Delete")
                    investmaster.IsActive = false;

            }
            else
                _context.InvestigatorMasters.Add(investigatormaster);

            _context.SaveChanges();
        }
    }
}
