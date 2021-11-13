using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MXN
{
    public partial class GUI_User : Form
    {
        public GUI_User()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }
        void Lock_Unlock(Boolean kt)
        {
            mnuLogout.Enabled = mnuWork.Enabled = !kt;
            mnuLogin.Enabled = mnuClose.Enabled = kt;
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
        }

        private void GUI_User_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
