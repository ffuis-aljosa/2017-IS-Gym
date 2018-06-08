using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjekatJIM
{
    public partial class FrmUserAccount : Form
    {
        public FrmUserAccount()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source = database.db;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from tblUserAcc";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void cleartext()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            frmMain aa = new frmMain();
            this.Hide();
            aa.Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == String.Empty || txtPass.Text == String.Empty)
                {
                    MessageBox.Show("Please insert data");
                }

                else
                {
                    string txtQuery = "insert into tblUserAcc (Username, Password)values ('" + txtUsername.Text + "', '" + txtPass.Text + "')";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    cleartext();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void FrmUserAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == String.Empty)
                {
                    MessageBox.Show("Please insert username");
                }
                else
                {
                    string txtQuery = "delete from tblUserAcc where Username = '" + txtUsername.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    cleartext();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == String.Empty || txtPass.Text == String.Empty)
                {
                    MessageBox.Show("Please insert data");
                }

                else
                {
                    string txtQuery = "update tblUserAcc set Username='"+txtUsername.Text+"', Password='"+txtPass.Text+"' where Username='"+txtUsername.Text+"'";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    cleartext();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtPass.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
