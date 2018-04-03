using ClinicalTrail.DataAccess.Model;
using System;
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
                     select resp;

            return cm.ToList();
        }

        public void AddCenterManager(CenterMaster centermanager)
        {
            if (!string.IsNullOrEmpty(centermanager.Center_No.ToString()))
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

        ///// <summary>
        ///// Change status of all the master controles used in the page
        ///// </summary>
        ///// <param name="ctrl"></param>
        ///// <param name="masterpagecontrlstatus"></param>
        ///// <param name="childpagecontrolstatus"></param>
        //public void FindControls()
        //{
        //    foreach (Control item in ctrl.Controls)
        //    {
        //        if (item is TextBox)
        //        {
        //            TextBox txb = (TextBox)item;
        //            txb.Enabled = masterpagecontrlstatus;
        //        }
        //        if (item is DropDownList)
        //        {
        //            DropDownList ddl = (DropDownList)item;
        //            ddl.Enabled = masterpagecontrlstatus;
        //        }
        //        if (item is CheckBox)
        //        {
        //            CheckBox chk = (CheckBox)item;
        //            chk.Enabled = masterpagecontrlstatus;
        //        }
        //        if (item is Button)
        //        {
        //            Button btn = (Button)item;
        //            btn.Enabled = masterpagecontrlstatus;
        //        }
        //        if (item is RadioButtonList)
        //        {
        //            RadioButtonList rbtnl = (RadioButtonList)item;
        //            rbtnl.Enabled = masterpagecontrlstatus;
        //        }
        //        if (item is LinkButton)
        //        {
        //            LinkButton lbtn = (LinkButton)item;
        //            lbtn.Enabled = masterpagecontrlstatus;
        //        }
        //        if (item is Panel)
        //        {
        //            Panel pnl = (Panel)item;
        //            pnl.Enabled = masterpagecontrlstatus;
        //        }
        //        FindChildControls(item, childpagecontrolstatus);
        //    }
        //}

        ///// <summary>
        ///// Change status of all the child controles used in the page
        ///// </summary>
        ///// <param name="ctrl"></param>
        ///// <param name="childpagecontrolstatus"></param>
        //public void FindChildControls(Control ctrl, bool childpagecontrolstatus)
        //{
        //    foreach (Control item in ctrl.Controls)
        //    {
        //        if (item is TextBox)
        //        {
        //            TextBox txb = (TextBox)item;
        //            txb.Enabled = childpagecontrolstatus;
        //        }
        //        if (item is DropDownList)
        //        {
        //            DropDownList ddl = (DropDownList)item;
        //            ddl.Enabled = childpagecontrolstatus;
        //        }
        //        if (item is CheckBox)
        //        {
        //            CheckBox chk = (CheckBox)item;
        //            chk.Enabled = childpagecontrolstatus;
        //        }
        //        if (item is Button)
        //        {
        //            Button btn = (Button)item;
        //            btn.Enabled = childpagecontrolstatus;
        //            btn.Visible = childpagecontrolstatus;
        //        }
        //        if (item is RadioButtonList)
        //        {
        //            RadioButtonList rbtnl = (RadioButtonList)item;
        //            rbtnl.Enabled = childpagecontrolstatus;
        //        }
        //        if (item is LinkButton)
        //        {
        //            LinkButton lbtn = (LinkButton)item;
        //            lbtn.Enabled = childpagecontrolstatus;
        //        }

        //        if (item is Panel)
        //        {
        //            Panel pnl = (Panel)item;
        //            pnl.Enabled = childpagecontrolstatus;
        //        }
        //        FindChildControls(item, childpagecontrolstatus);
        //    }
        //}
    }
}
