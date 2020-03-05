using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel;

using System.Windows.Forms;
using System.Data.Entity;
using ProjectBNG.Class;

namespace ProjectBNG.Class
{
     class CommonFunction
    {
        public static bool checkExistForm(string name,Form form)
        {
            bool check = false;
            foreach (Form newForm in form.MdiChildren)
            {
                if (newForm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public static void activateForm(string name,Form form)
        {
            foreach(Form newForm in form.MdiChildren)
            {
                if (newForm.Name == name)
                {
                    newForm.Activate();
                    break;
                }
            }
        }
        public static bool cal(int _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        
        }
    
}
