using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btAddMember_Click(object sender, EventArgs e)
        {
            FrmAddMember aa = new FrmAddMember();
            this.Hide();
            aa.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btAppExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
