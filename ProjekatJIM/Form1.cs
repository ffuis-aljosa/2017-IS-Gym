using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatJIM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckShowPass.Checked)
                txtPassword.UseSystemPasswordChar = true;

            else
                txtPassword.UseSystemPasswordChar = false;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
