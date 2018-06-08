using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjekatJIM
{
    public partial class FrmAddMember : Form
    {
        public FrmAddMember()
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

        private void ExecuteQuery (string txtQuery)
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
            string CommandText = "select * from tblAddM";
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
            cmbGender.SelectedItem = null;
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtContact.Text = "";
            cmbBatch.SelectedItem = null;
            cmbMember.SelectedItem = null;
            cmbWorkout.SelectedItem = null;
            cmbFeesMode.SelectedItem = null;
            txtRecNo.Text = "";
        }

        private void FrmAddMember_Load(object sender, EventArgs e)
        {
            LoadData();
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
                if (txtName.Text == String.Empty || cmbGender.Text == String.Empty || txtHeight.Text == String.Empty || txtHeight.Text == String.Empty || txtWeight.Text == String.Empty || txtContact.Text == String.Empty || cmbBatch.Text == String.Empty || cmbMember.Text == String.Empty || cmbWorkout.Text == String.Empty || cmbFeesMode.Text == String.Empty || txtRecNo.Text == String.Empty)
                {
                    MessageBox.Show("Please inset data");
                }

                else
                {
                    string txtQuery = "insert into tblAddM (Name, Gender, Height, Weight, Contact, Batch, Member, Workout, FeesMode, RecNo)values " +
                    "('" + txtName.Text + "','" + cmbGender.Text + "', '" + txtHeight.Text + "','" + txtWeight.Text + "', '" + txtContact.Text + "',  '" + cmbBatch.Text + "', '" + cmbMember.Text + "', '" + cmbWorkout.Text + "', '" + cmbFeesMode.Text + "', '" + cmbWorkout.Text + "' )";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    cleartext();
                    MessageBox.Show("Successfully saved");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
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
                    string txtQuery = "delete from tblAddM where Name = '" + txtName.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    cleartext();
                    MessageBox.Show("Successfully removed");
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
                if (txtName.Text == String.Empty || cmbGender.Text == String.Empty || txtHeight.Text == String.Empty || txtHeight.Text == String.Empty || txtWeight.Text == String.Empty || txtContact.Text == String.Empty || cmbBatch.Text == String.Empty || cmbMember.Text == String.Empty || cmbWorkout.Text == String.Empty || cmbFeesMode.Text == String.Empty || txtRecNo.Text == String.Empty)
                {
                    MessageBox.Show("Please insert data");
                }

                else
                {
                    string txtQuery = "update tblAddM set Name ='" + txtName.Text + "', Gender='" + cmbGender.Text + "', Height='" + txtHeight.Text + "', Weight='" + txtWeight.Text + "', Contact='" + txtContact.Text + "', Batch='" + cmbBatch.Text + "', Member='" + cmbMember.Text + "', Workout='" + cmbWorkout.Text + "', FeesMode='" + cmbFeesMode.Text + "', RecNo='" + txtRecNo.Text + "' where Name='" + txtName.Text + "'";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    MessageBox.Show("Member successfully edited");
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
            cmbGender.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtHeight.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtWeight.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtContact.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmbBatch.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cmbMember.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cmbWorkout.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            cmbFeesMode.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtRecNo.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

        }
    }
}
