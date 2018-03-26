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
    public partial class FrmFeesRecieve : Form
    {
        public FrmFeesRecieve()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            frmMain aa = new frmMain();
            this.Hide();
            aa.Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
