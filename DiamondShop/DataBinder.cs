using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace DiamondShop
{
    public class DataBinder
    {
        Hashtable arrBindControl = new Hashtable();
        Hashtable arrBindControlPropety = new Hashtable();

        public void BindControl(Control ctrl, string columnName)
        {
            BindControl(ctrl, columnName, "");
        }

        public void BindControl(Control ctrl, string columnName, string property)
        {
            Hashtable arr = arrBindControl;
            if (!arr.ContainsKey(columnName)) arr.Add(columnName, ctrl);
            else arr[columnName] = ctrl;

            if (!arrBindControlPropety.ContainsKey(columnName)) arrBindControlPropety.Add(columnName, property);
            else arrBindControlPropety[columnName] = property;
        }

        #region Bind Value to Control
        public void BindValueToControl(DataRow row)
        {
            if (row != null)
            {
                Hashtable arr = arrBindControl;
                foreach (string columnName in arr.Keys)
                {
                    if (row.Table.Columns.Contains(columnName) && !row.IsNull(columnName))
                    {
                        Control ctrl = (Control)arr[columnName];
                        switch (ctrl.GetType().FullName)
                        {
                            case "System.Windows.Forms.TextBox":
                                if (!row.IsNull(columnName)) ((TextBox)ctrl).Text = row[columnName].ToString();
                                else ((TextBox)ctrl).Text = "";
                                break;
                            case "System.Windows.Forms.CheckBox":
                                CheckBox chk = (CheckBox)ctrl;
                                if (!row.IsNull(columnName) && row.Table.Columns[columnName].DataType == typeof(bool)) chk.Checked = (bool)row[columnName];
                                else chk.Checked = false;
                                break;
                            case "System.Windows.Forms.ComboBox":
                                ComboBox cmb = (ComboBox)ctrl;
                                if (!row.IsNull(columnName)) 
                                {
                                  cmb.SelectedValue = row[columnName].ToString();
                                }
                                else cmb.SelectedValue = null;
                                break;
                            case "System.Windows.Forms.DateTimePicker":
                                if (!row.IsNull(columnName)) ((DateTimePicker)ctrl).Value = Convert.ToDateTime(row[columnName]);
                                break;
                        
                            default: break;
                        }
                    }
                }
            }
        }
        #endregion

        #region Value to Row
        public void BindValueToDataRow(DataRow row)
        {
            if (row != null)
            {
                Hashtable arr = arrBindControl;
                foreach (string columnName in arr.Keys)
                {
                    if (row.Table.Columns.Contains(columnName))
                    {
                        Control ctrl = (Control)arr[columnName];
                        switch (ctrl.GetType().FullName)
                        {
                            case "System.Windows.Forms.TextBox":
                                row[columnName] = ((TextBox)ctrl).Text.Trim();
                                break;
                            case "System.Windows.Forms.CheckBox":
                                CheckBox chk = (CheckBox)ctrl;
                                row[columnName] = chk.Checked?'1':'0';
                                break;
                            case "System.Windows.Forms.ComboBox":
                                ComboBox cmb = (ComboBox)ctrl;
                                row[columnName] = cmb.SelectedValue;
                                break;
                            case "System.Windows.Forms.DateTimePicker":
                                DateTimePicker rdp = (DateTimePicker)ctrl;
                                if (rdp.Value.Year == 1) row[columnName] = DBNull.Value;
                                else row[columnName] = rdp.Value;
                                break;
                            default: break;
                        }
                    }
                }
            }
        }
        #endregion

        #region Clear Control
        public void ClearControl()
        {
            try
            {
                Hashtable arr = arrBindControl;
                foreach (string columnName in arr.Keys)
                {
                    Control ctrl = (Control)arr[columnName];
                    switch (ctrl.GetType().FullName)
                    {
                        case "System.Windows.Forms.TextBox":
                            ((TextBox)ctrl).Text = "";
                            break; 
                        case "System.Windows.Forms.CheckBox":
                            CheckBox chk = (CheckBox)ctrl;
                            chk.Checked = false;
                            break; 
                        case "System.Windows.Forms.DateTimePicker":
                            ((DateTimePicker)ctrl).Value = DateTime.Now;
                            break;
                        default: break;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}