using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjekatJIM
{
    public partial class FrmFeesRecieve : Form
    {
        public FrmFeesRecieve()
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
            string CommandText = "select * from tblFees";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void cleartext()
        {
            txtName.Text = "";
            txtFees.Text = "";
            cmbWorkout.SelectedItem = null;
            cmbFeesMode.SelectedItem = null;
            txtRecNo.Text = "";
            dateTimePicker1.Text = null; 
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

        private void FrmFeesRecieve_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == String.Empty)
                {
                    MessageBox.Show("Please insert name");
                }
                else
                {
                    string txtQuery = "delete from tblFees where Name = '" + txtName.Text + "'";
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

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == String.Empty || txtFees.Text == String.Empty || cmbFeesMode.Text == String.Empty || txtRecNo.Text == String.Empty || cmbWorkout.Text == String.Empty)
                {
                    MessageBox.Show("Please insert data");
                }

                else
                {
                    string txtQuery = "insert into tblFees (Name, Fees, FeesMode, RecNo, Workout, Date)values " +
                        "('" + txtName.Text + "', '" + txtFees.Text + "', '" + cmbFeesMode.Text + "', '" + txtRecNo.Text + "', '" + cmbWorkout.Text + "', '" + dateTimePicker1.Text + "')";
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
                if (txtName.Text == String.Empty || txtFees.Text == String.Empty || cmbFeesMode.Text == String.Empty || txtRecNo.Text == String.Empty || cmbWorkout.Text == String.Empty)
                {
                    MessageBox.Show("Please insert data");
                }

                else
                {
                    string txtQuery = "update tblFees set Name='" + txtName.Text + "', Fees= '" + txtFees.Text + "', FeesMode='" + cmbFeesMode.Text + "', RecNo='" + txtRecNo.Text + "', Workout='" + cmbWorkout.Text + "', Date='" + dateTimePicker1.Text + "' where Name='" + txtName.Text + "'";
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
            txtName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtFees.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cmbFeesMode.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtRecNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cmbWorkout.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
