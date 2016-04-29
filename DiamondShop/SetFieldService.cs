using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DiamondShop
{
    public class SetFieldService
    {
        public static void SetRequireField(params Control[] ctrlList)
        {
            Color cl = Color.LemonChiffon;
            foreach (Control ctrl in ctrlList)
            {
                switch (ctrl.GetType().FullName)
                {
                    case "System.Windows.Forms.TextBox":
                        ((TextBox)ctrl).BackColor = cl;
                        break;
                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)ctrl).BackColor = cl;
                        break;
                    case "System.Windows.Forms.DateTimePicker":
                        ((DateTimePicker)ctrl).BackColor = cl;
                        break;
                }
            }
        }
        public static void SetReadOnlyField(params Control[] ctrlList)
        {
            Color cl = Color.WhiteSmoke;

            foreach (Control ctrl in ctrlList)
            {
                switch (ctrl.GetType().FullName)
                {
                    case "System.Windows.Forms.TextBox":
                        ((TextBox)ctrl).BackColor = cl;
                        break;
                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)ctrl).BackColor = cl;
                        break;
                    case "System.Windows.Forms.DateTimePicker":
                        ((DateTimePicker)ctrl).BackColor = cl;
                        break;
                }
            }
        }
    }
}
