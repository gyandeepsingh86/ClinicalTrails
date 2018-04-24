using ClinicalTrail.DataAccess.Model;
using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.DataAccess.Factory
{
    public class CenterMasterFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public CenterMasterFactory(ClinicalTrialsDBEntities entities)
        {
            _context = entities;
        }

        public List<CenterMaster> GetAllCenterMaster()
        {
            var cm = from resp in _context.CenterMasters
                     where resp.IsActive != false
                     select resp;

            return cm.ToList();
        }

        public void AddCenterManager(CenterMaster centermanager)
        {
            if (!string.IsNullOrEmpty(centermanager.Center_No.ToString()) && centermanager.Center_No != 0)
            {
                var result = (from resp in _context.CenterMasters
                              where resp.Center_No == centermanager.Center_No
                              select resp).FirstOrDefault();

                result.Bank_Account_Number = centermanager.Bank_Account_Number;
                result.Center_Name = centermanager.Center_Name;
                result.Center_Type = centermanager.Center_Type;
                result.City = centermanager.City;
                result.Country = centermanager.Country;
                result.Email = centermanager.Email;
                result.Equipments = centermanager.Equipments;
                result.Investigator_1 = centermanager.Investigator_1;
                result.Investigator_2 = centermanager.Investigator_2;
                result.Investigator_3 = centermanager.Investigator_3;
                result.Mobile_Phone = centermanager.Mobile_Phone;
                result.Office_Phone = centermanager.Office_Phone;
                result.Payee_Name = centermanager.Payee_Name;
                result.Post_code = centermanager.Post_code;
                result.Primary_Email = centermanager.Primary_Email;
                result.Secondary_Email = centermanager.Secondary_Email;
                result.Specialties = centermanager.Specialties;
                result.State = centermanager.State;
                result.Street_Address = centermanager.Street_Address;
                result.Website = centermanager.Website;
            }
            else
                _context.CenterMasters.Add(centermanager);

            _context.SaveChanges();
        }

        public CenterMaster GetCenterManager(int CenterNo)
        {
            var cm = from resp in _context.CenterMasters
                     where resp.Center_No == CenterNo
                     select resp;
            return cm.FirstOrDefault();
        }

        public List<CenterMaster> FilterCenterManager(CenterMaster filter)
        {
            return FilterCenterManagerList(filter).ToList();
        }

        public IQueryable<CenterMaster> FilterCenterManagerList(CenterMaster filter)
        {
            IQueryable<CenterMaster> query = _context.CenterMasters;

            //query = query.Like(a => a.Bank_Account_Number, filter.Email, true);
            //query = query.Like(a => a.Center_Name, filter.Primary_Email, true);
            //query = query.Like(a => a.Center_No, filter.Secondary_Email, true);
            //query = query.Like(a => a.Center_Type, filter.Payee_Name, true);

            //query = query.Equals(a => a., filter.Bank_Account_Number);
            //query = query.Equals(a => a.Center_Name, filter.Center_Name);
            //query = query.Equals(a => a.Center_No, filter.Center_No);
            //query = query.Equals(a => a.Center_Type, filter.Center_Type);
            //query = query.Equals(a => a.Report_HandledBy, filter.City);
            //query = query.Equals(a => a.Report_FailAreaCode, filter.Country);
            //query = query.Equals(a => a.Report_FailComponentCode, filter.FailComponentCode, true);
            //query = query.Equals(a => a.Report_FailReasonCode, filter.FailReasonCode, true);

            //query = query.IsMember(a => a.Report_FamCode, filter.FamCode);

            if (!string.IsNullOrEmpty(filter.Bank_Account_Number))
                query = query.Where(a => a.Bank_Account_Number != null && a.Bank_Account_Number == filter.Bank_Account_Number);

            if (!string.IsNullOrEmpty(filter.Center_Name))
                query = query.Where(a => a.Center_Name != null && a.Center_Name.Contains(filter.Center_Name));

            if (filter.Center_No >= 0)
                query = query.Where(a => a.Center_No != null && a.Center_No == filter.Center_No);

            if (!string.IsNullOrEmpty(filter.Center_Type))
                query = query.Where(a => a.Center_Type != null && a.Center_Type.Contains(filter.Center_Type));

            if (!string.IsNullOrEmpty(filter.City))
                query = query.Where(a => a.City != null && a.City == filter.City);

            if (!string.IsNullOrEmpty(filter.Country))
                query = query.Where(a => a.Country != null && a.Country == filter.Country);

            if (!string.IsNullOrEmpty(filter.Email))
                query = query.Where(a => a.Email != null && a.Email.Contains(filter.Email));

            if (!string.IsNullOrEmpty(filter.Equipments))
                query = query.Where(a => a.Equipments != null && a.Equipments.Contains(filter.Equipments));

            if (!string.IsNullOrEmpty(filter.IsActive.ToString()))
                query = query.Where(a => a.IsActive != null || a.IsActive == filter.IsActive);

            if (!string.IsNullOrEmpty(filter.Investigator_1))
                query = query.Where(a => a.Investigator_1 != null && a.Investigator_1.Contains(filter.Investigator_1));

            if (!string.IsNullOrEmpty(filter.Investigator_2))
                query = query.Where(a => a.Investigator_2 != null && a.Investigator_2.Contains(filter.Investigator_2));

            if (!string.IsNullOrEmpty(filter.Investigator_3))
                query = query.Where(a => a.Investigator_3 != null && a.Investigator_3.Contains(filter.Investigator_3));

            if (!string.IsNullOrEmpty(filter.Mobile_Phone))
                query = query.Where(a => a.Mobile_Phone != null && a.Mobile_Phone == filter.Mobile_Phone);

            if (!string.IsNullOrEmpty(filter.Office_Phone))
                query = query.Where(a => a.Office_Phone != null && a.Office_Phone == filter.Office_Phone);

            if (!string.IsNullOrEmpty(filter.Payee_Name))
                query = query.Where(a => a.Payee_Name != null && a.Payee_Name.Contains(filter.Payee_Name));

            if (!string.IsNullOrEmpty(filter.Post_code))
                query = query.Where(a => a.Post_code != null && a.Post_code == filter.Post_code);

            if (!string.IsNullOrEmpty(filter.Primary_Email))
                query = query.Where(a => a.Primary_Email != null && a.Primary_Email == filter.Primary_Email);

            if (!string.IsNullOrEmpty(filter.Secondary_Email))
                query = query.Where(a => a.Secondary_Email != null && a.Secondary_Email == filter.Secondary_Email);

            if (!string.IsNullOrEmpty(filter.Specialties))
                query = query.Where(a => filter.Specialties.Contains(a.Specialties));

            if (!string.IsNullOrEmpty(filter.State))
                query = query.Where(a => a.State != null && a.State == filter.State);

            if (!string.IsNullOrEmpty(filter.Street_Address))
                query = query.Where(a => a.Street_Address != null && a.Street_Address.Contains(filter.Street_Address));

            if (!string.IsNullOrEmpty(filter.Website))
                query = query.Where(a => a.Website != null || filter.Website.Contains(a.Website));


            //// shows you the sql query
            //string aa = ((ObjectQuery)query).ToTraceString();
            //string b = aa;
            //Console.WriteLine(b);

            return query;
        }

        public List<CityMaster> GetAllCityMaster()
        {
            var list = from lst in _context.CityMasters
                       select lst;

            return list.Take(50).ToList();
        }

        public bool DeleteCenterManager(int centno)
        {
            CenterMaster cm = GetCenterManager(centno);
            if (cm != null)
            {
                cm.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
