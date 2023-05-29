using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;
namespace webMAN_Manager.Classes
{
    internal class ConfigDrawer
    {
        public static void Show(Form target, object configClass)
        {

            var t = configClass.GetType();
            var props = t.GetProperties();

            foreach (var prop in props)
            {
                target.Controls.Add(GetNew(prop));
            }
        }
        static int _offsetDrawY;
        private static Guna2CheckBox GetNew(PropertyInfo prop)
        {
            var val = prop.GetValue(prop);
            var gctrl = new Guna2CheckBox()
            {
                Text = prop.Name,
                Enabled = (val is bool) & ((bool)val is true),
                BackColor = Color.FromArgb(20, 20, 20),
                ForeColor = Color.FromArgb(200, 200, 200),
                Location = new Point(30, _offsetDrawY),
            };
            _offsetDrawY += gctrl.Height;
            return gctrl;
        }
    }
}
