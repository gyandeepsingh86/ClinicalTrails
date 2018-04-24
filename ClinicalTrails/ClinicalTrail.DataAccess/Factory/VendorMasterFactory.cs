using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.DataAccess.Factory
{
    public class VendorMasterFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public VendorMasterFactory(ClinicalTrialsDBEntities entities)
        {
            _context = entities;
        }

        public List<VendorMaster> GetAllVendorMaster()
        {
            var cm = from resp in _context.VendorMasters
                     where resp.IsActive != false
                     select resp;

            return cm.ToList();
        }

        public void AddVendorManager(VendorMaster Vendormanager)
        {
            if (!string.IsNullOrEmpty(Vendormanager.Vendor_No.ToString()) && Vendormanager.Vendor_No != 0)
            {
                var result = (from resp in _context.VendorMasters
                              where resp.Vendor_No == Vendormanager.Vendor_No
                              select resp).FirstOrDefault();

                result.Bank_Account_Number = Vendormanager.Bank_Account_Number;
                result.Vendor_Name = Vendormanager.Vendor_Name;
                result.Vendor_Type = Vendormanager.Vendor_Type;
                result.City = Vendormanager.City;
                result.Country = Vendormanager.Country;
                result.Email = Vendormanager.Email;
                result.Equipments = Vendormanager.Equipments;
                result.Mobile_Phone = Vendormanager.Mobile_Phone;
                result.Office_Phone = Vendormanager.Office_Phone;
                result.Payee_Name = Vendormanager.Payee_Name;
                result.Post_code = Vendormanager.Post_code;
                result.Primary_Email = Vendormanager.Primary_Email;
                result.Secondary_Email = Vendormanager.Secondary_Email;
                result.Specialties = Vendormanager.Specialties;
                result.State = Vendormanager.State;
                result.Street_Address = Vendormanager.Street_Address;
                result.Website = Vendormanager.Website;
            }
            else
                _context.VendorMasters.Add(Vendormanager);

            _context.SaveChanges();
        }

        public VendorMaster GetVendorManager(int VendorNo)
        {
            var cm = from resp in _context.VendorMasters
                     where resp.Vendor_No == VendorNo
                     select resp;
            return cm.FirstOrDefault();
        }

        public List<VendorMaster> FilterVendorManager(VendorMaster filter)
        {
            return FilterVendorManagerList(filter).ToList();
        }

        public IQueryable<VendorMaster> FilterVendorManagerList(VendorMaster filter)
        {
            IQueryable<VendorMaster> query = _context.VendorMasters;

            if (!string.IsNullOrEmpty(filter.Bank_Account_Number))
                query = query.Where(a => a.Bank_Account_Number != null && a.Bank_Account_Number == filter.Bank_Account_Number);

            if (!string.IsNullOrEmpty(filter.Vendor_Name))
                query = query.Where(a => a.Vendor_Name != null && a.Vendor_Name.Contains(filter.Vendor_Name));

            if (filter.Vendor_No >= 0)
                query = query.Where(a => a.Vendor_No != null && a.Vendor_No == filter.Vendor_No);

            if (!string.IsNullOrEmpty(filter.Vendor_Type))
                query = query.Where(a => a.Vendor_Type != null && a.Vendor_Type.Contains(filter.Vendor_Type));

            if (!string.IsNullOrEmpty(filter.City))
                query = query.Where(a => a.City != null && a.City == filter.City);

            if (!string.IsNullOrEmpty(filter.Country))
                query = query.Where(a => a.Country != null && a.Country == filter.Country);

            if (!string.IsNullOrEmpty(filter.Email))
                query = query.Where(a => a.Email != null && a.Email.Contains(filter.Email));

            if (!string.IsNullOrEmpty(filter.IsActive.ToString()))
                query = query.Where(a => a.IsActive != null || a.IsActive == filter.IsActive);

            if (!string.IsNullOrEmpty(filter.Equipments))
                query = query.Where(a => a.Equipments != null && a.Equipments.Contains(filter.Equipments));

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

            return query;
        }

        public bool DeleteVendorManager(int centno)
        {
            VendorMaster cm = GetVendorManager(centno);
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
