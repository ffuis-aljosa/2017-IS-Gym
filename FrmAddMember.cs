using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projekat
{
    public partial class FrmAddMember : Form
    {
        SqlConnection sqlCon = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Korisnik\source\repos\Projekat\Projekat\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        public FrmAddMember()
        {
            InitializeComponent();
        }

        private void FrmAddMember_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbWeight_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("MemberAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@idMember", 0);
                sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Gender", cmbGender.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Height", txtHeight.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Weight", txtWeight.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Batch", cmbBatch.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Member", cmbMember.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Workout", cmbWorkout.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@FeesMode", cmbFeesMode.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@RecNo", txtRecNo.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
            finally
            {
                sqlCon.Close();
                displayData();
                cleartext();
            }
        }

        private void displayData()
        {
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_member";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tbl_member where Name = '"+txtName.Text+"'";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            displayData();
            txtName.Text = ""; 
            MessageBox.Show("Member is deleted successfully");
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

}
