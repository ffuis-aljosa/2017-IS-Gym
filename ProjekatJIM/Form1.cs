using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjekatJIM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string dbcon = @"Data Source = database.db;";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
                

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
             txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            if ((txtUsername.Text == "") && (txtPassword.Text == "") || (txtUsername.Text == "") || (txtPassword.Text == ""))
            {
                MessageBox.Show("Username or password are empty");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string query = "SELECT * FROM tblUserAcc WHERE username='" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                    SQLiteCommand com = new SQLiteCommand(query, sqlcon);
                    com.ExecuteNonQuery();
                    SQLiteDataReader dr = com.ExecuteReader();
                    int count = 0;
                    while (dr.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        frmMain vv = new frmMain();
                        vv.Show();
                        this.Hide();
                    }
                    if (count < 1)
                    {
                        MessageBox.Show("Username or password are invalid");
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
