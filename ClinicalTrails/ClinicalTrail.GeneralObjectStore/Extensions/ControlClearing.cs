using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicalTrail.GeneralObjectStore.Extensions
{
    public static class ControlClearing
    {
        //    private static Dictionary<Type, Action<Control>> controldefaults = new Dictionary<Type, Action<Control>>() { 
        //        {typeof(TextBox), c => ((TextBox)c).Clear()},
        //        {typeof(CheckBox), c => ((CheckBox)c).Checked = false},
        //        {typeof(ListBox), c => ((ListBox)c).Items.Clear()},
        //        {typeof(RadioButton), c => ((RadioButton)c).Checked = false},
        //        {typeof(GroupBox), c => ((GroupBox)c).Controls.ClearControls()},
        //        {typeof(Panel), c => ((Panel)c).Controls.ClearControls()}
        //        };

        //    private static void FindAndInvoke(Type type, Control control)
        //    {
        //        if (controldefaults.ContainsKey(type))
        //        {
        //            controldefaults[type].Invoke(control);
        //        }
        //    }

        //    public static void ClearControls(this Control.ControlCollection controls)
        //    {
        //        foreach (Control control in controls)
        //        {
        //            FindAndInvoke(control.GetType(), control);
        //        }
        //    }

        //    public static void ClearControls<T>(this Control.ControlCollection controls) where T : class
        //    {
        //        if (!controldefaults.ContainsKey(typeof(T))) return;

        //        foreach (Control control in controls)
        //        {
        //            if (control.GetType().Equals(typeof(T)))
        //            {
        //                FindAndInvoke(typeof(T), control);
        //            }
        //        }
        //    }
        //}

        public static void ClearAllControls(Control ctrl)
        {
            //Clear Master Page Controls
            foreach (System.Web.UI.Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txb = (TextBox)item;
                    txb.Text = string.Empty;
                }
                if (item is DropDownList)
                {
                    DropDownList ddl = (DropDownList)item;
                    ddl.SelectedIndex = 0;
                }
                if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }

                if (item is RadioButtonList)
                {
                    RadioButtonList rbtnl = (RadioButtonList)item;
                    rbtnl.SelectedIndex = 0;
                }
                if (item is LinkButton)
                {
                    LinkButton lbtn = (LinkButton)item;
                    lbtn.Text = string.Empty;
                }

                //Disable child page controls
                ClearChildControls(item);
            }

        }

        public static void ClearChildControls(Control ctrl)
        {
            foreach (System.Web.UI.Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txb = (TextBox)item;
                    txb.Text = string.Empty;
                }
                if (item is DropDownList)
                {
                    DropDownList ddl = (DropDownList)item;
                    ddl.SelectedIndex = 0;
                }
                if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }

                if (item is RadioButtonList)
                {
                    RadioButtonList rbtnl = (RadioButtonList)item;
                    rbtnl.SelectedIndex = 0;
                }
                if (item is LinkButton)
                {
                    LinkButton lbtn = (LinkButton)item;
                    lbtn.Text = string.Empty;
                }
            }
        }
    }
}
