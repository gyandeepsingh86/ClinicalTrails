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
                    where resp.ID == id
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

        public void DeleteInvestigatoMaster(int id)
        {
            var investmaster = (from result in _context.InvestigatorMasters
                        select result).FirstOrDefault();

            if (investmaster != null)
            {
                investmaster.IsActive = false;
            }
            _context.SaveChanges();
        }

        public List<InvestigatorMaster> GetSearchResultForInvestigatorMaster(InvestigatorMaster searchlist)
        {
            return GetSearchResultForInvestigatorMasterList(searchlist).ToList();
        }

        private IQueryable<InvestigatorMaster> GetSearchResultForInvestigatorMasterList(InvestigatorMaster searchlist)
        {
            IQueryable<InvestigatorMaster> query = _context.InvestigatorMasters;

            if (!string.IsNullOrEmpty(searchlist.Bank_Account_Number))
                query = query.Where(a => a.Bank_Account_Number != null && a.Bank_Account_Number == searchlist.Bank_Account_Number);

            if (!string.IsNullOrEmpty(searchlist.Address_Type))
                query = query.Where(a => a.Address_Type != null && a.Address_Type.Contains(searchlist.Address_Type));

            if (searchlist.ID >= 0)
                query = query.Where(a => a.ID != null && a.ID == searchlist.ID);

            if (!string.IsNullOrEmpty(searchlist.Centre_1))
                query = query.Where(a => a.Centre_1 != null && a.Centre_1.Contains(searchlist.Centre_1));

            if (!string.IsNullOrEmpty(searchlist.Centre_2))
                query = query.Where(a => a.Centre_2 != null && a.Centre_2.Contains(searchlist.Centre_2));

            if (!string.IsNullOrEmpty(searchlist.Centre_3))
                query = query.Where(a => a.Centre_3 != null && a.Centre_3.Contains(searchlist.Centre_3));

            if (!string.IsNullOrEmpty(searchlist.Certification))
                query = query.Where(a => a.Certification != null && a.Certification.Contains(searchlist.Certification));

            if (!string.IsNullOrEmpty(searchlist.City))
                query = query.Where(a => a.City != null && a.City == searchlist.City);

            if (!string.IsNullOrEmpty(searchlist.Country))
                query = query.Where(a => a.Country != null && a.Country == searchlist.Country);

            if (!string.IsNullOrEmpty(searchlist.Degree))
                query = query.Where(a => a.Degree != null && a.Degree.Contains(searchlist.Degree));

            if (!string.IsNullOrEmpty(searchlist.Email_ID))
                query = query.Where(a => a.Email_ID != null && a.Email_ID.Contains(searchlist.Email_ID));

            if (!string.IsNullOrEmpty(searchlist.Fax_No))
                query = query.Where(a => a.Fax_No != null && a.Fax_No == searchlist.Fax_No);
            
            if (!string.IsNullOrEmpty(searchlist.Institute_Name))
                query = query.Where(a => a.Institute_Name != null && a.Institute_Name == searchlist.Institute_Name);

            if (!string.IsNullOrEmpty(searchlist.Investigator_First_Name))
                query = query.Where(a => a.Investigator_First_Name != null && a.Investigator_First_Name == searchlist.Investigator_First_Name);

            if (!string.IsNullOrEmpty(searchlist.Investigator_Last_Name))
                query = query.Where(a => a.Investigator_Last_Name != null && a.Investigator_Last_Name == searchlist.Investigator_Last_Name);

            if (!string.IsNullOrEmpty(searchlist.Investigator_Middle_Name))
                query = query.Where(a => a.Investigator_Middle_Name != null && a.Investigator_Middle_Name == searchlist.Investigator_Middle_Name);

            if (!string.IsNullOrEmpty(searchlist.IsActive.ToString()))
                query = query.Where(a => a.IsActive != null && a.IsActive == searchlist.IsActive);

            if (!string.IsNullOrEmpty(searchlist.Mobile_Phone))
                query = query.Where(a => a.Mobile_Phone != null && a.Mobile_Phone == searchlist.Mobile_Phone);

            if (!string.IsNullOrEmpty(searchlist.Office_Phone))
                query = query.Where(a => a.Office_Phone != null && a.Office_Phone == searchlist.Office_Phone);

            if (!string.IsNullOrEmpty(searchlist.Payee_Name))
                query = query.Where(a => a.Payee_Name != null && a.Payee_Name.Contains(searchlist.Payee_Name));

            if (!string.IsNullOrEmpty(searchlist.Post_Code))
                query = query.Where(a => a.Post_Code != null && a.Post_Code == searchlist.Post_Code);

            if (!string.IsNullOrEmpty(searchlist.Primary_Email))
                query = query.Where(a => a.Primary_Email != null && a.Primary_Email == searchlist.Primary_Email);

            if (!string.IsNullOrEmpty(searchlist.Secondary_Email_ID))
                query = query.Where(a => a.Secondary_Email_ID != null && a.Secondary_Email_ID == searchlist.Secondary_Email_ID);

            if (!string.IsNullOrEmpty(searchlist.Speciality))
                query = query.Where(a => searchlist.Speciality.Contains(a.Speciality));

            if (!string.IsNullOrEmpty(searchlist.State))
                query = query.Where(a => a.State != null && a.State == searchlist.State);

            if (!string.IsNullOrEmpty(searchlist.Street_Address))
                query = query.Where(a => a.Street_Address != null && a.Street_Address.Contains(searchlist.Street_Address));

            if (!string.IsNullOrEmpty(searchlist.Title))
                query = query.Where(a => a.Title != null && searchlist.Title.Contains(a.Title));

            return query;
        }
    }
}
