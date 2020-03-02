using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
