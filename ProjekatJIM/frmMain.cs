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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btAppExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPurchaseProduct_Click(object sender, EventArgs e)
        {
            FrmPurchaseProduct dd = new FrmPurchaseProduct();
            this.Hide();
            dd.Show();
        }

        private void btMemberFeesRecieve_Click(object sender, EventArgs e)
        {
            FrmFeesRecieve cc = new FrmFeesRecieve();
            this.Hide();
            cc.Show();
        }

        private void btAddMember_Click(object sender, EventArgs e)
        {
            FrmAddMember bb = new FrmAddMember();
            this.Hide();
            bb.Show();
        }

        private void btUserAcc_Click(object sender, EventArgs e)
        {
            FrmUserAccount bb = new FrmUserAccount();
            this.Hide();
            bb.Show();
        }
    }
}
