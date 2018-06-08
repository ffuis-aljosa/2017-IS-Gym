using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjekatJIM
{
    public partial class FrmPurchaseProduct : Form
    {
        public FrmPurchaseProduct()
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
            string CommandText = "select * from tblPurchase";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void cleartext()
        {
            txtProductName.Text = "";
            txtquantity.Text = "";
            txtAmount.Text = "";
            txtDescription.Text = "";

        }

        private void FrmPurchaseProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void lbamount_Click(object sender, EventArgs e)
        {

        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == String.Empty)
                {
                    MessageBox.Show("Please insert product name");
                }
                else
                {
                    string txtQuery = "delete from tblPurchase where ProductName = '" + txtProductName.Text + "'";
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

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == String.Empty || txtquantity.Text == String.Empty || txtAmount.Text == String.Empty || txtDescription.Text == String.Empty)
                {
                    MessageBox.Show("Please insert data");
                }

                else
                {
                    string txtQuery = "insert into tblPurchase (ProductName, Quantity, Amount, Description)values " +
                        "('" + txtProductName.Text + "', '" + txtquantity.Text + "', '" + txtAmount.Text + "', '" + txtDescription.Text + "')";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    cleartext();
                    MessageBox.Show("Successfully saved");
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
                if (txtProductName.Text == String.Empty || txtquantity.Text == String.Empty || txtAmount.Text == String.Empty || txtDescription.Text == String.Empty)
                {
                    MessageBox.Show("Please insert data");
                }

                else
                {
                    string txtQuery = "update tblPurchase set ProductName='" + txtProductName.Text + "', Quantity='" + txtquantity.Text + "', Amount='" + txtAmount.Text + "', Description='" + txtDescription.Text + "' where ProductName='"+txtProductName.Text+"'";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    cleartext();
                    MessageBox.Show("Successfully saved");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtquantity.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAmount.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtDescription.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
