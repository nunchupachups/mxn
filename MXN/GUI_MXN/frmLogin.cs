using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_MXN;
using GUI_MXN;

namespace GUI_MXN
{
    public partial class frmLogin : Form
    {
        BUS_User busUser = new BUS_User();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Username or Password is empty!", "Attention");
            /*else if (busUser.ktdn(txtUsername.Text, txtPassword.Text))
            {
                DataTable da = busUser.getUser(txtUsername.Text);
                mySave.KT = !mySave.KT;
                MessageBox.Show("Login Successful!", "Attention");
                //doi ten system
                Close();
            } */
            else if (busUser.ktdn(txtUsername.Text, txtPassword.Text).Rows.Count>0)
            {
                DataTable da = busUser.ktdn(txtUsername.Text, txtPassword.Text);
                mySave.KT = !mySave.KT;
                MessageBox.Show("Login Successful!", "Attention");
                //doi ten system
                Close();
            }
            else MessageBox.Show("Username or Password is not correct!", "Attention");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
