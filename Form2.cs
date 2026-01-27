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

namespace QDentalStockApp26
{
    public partial class frmItems : Form
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=QDental;Trusted_Connection=True;";

        public frmItems()
        {
            InitializeComponent();

        }

        private void btnAddRec_Click(object sender, EventArgs e)
        { 
            


           string sql = @" INSERT INTO dbo.Items(Consumable,Description,QuantityPPackage,UnitsPPackage,PricePPackage,PricePUnit) VALUES
            (@Consumable,@Description,@QuantityPPackage,@UnitsPPackage,@PricePPackage,@PricePUnit);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Consumable", "Bands");
                cmd.Parameters.AddWithValue("@Description", "Braces rubber bands");
                cmd.Parameters.AddWithValue("@QuantityPPackage", 10);
                cmd.Parameters.AddWithValue("@UnitsPPackage", 1);
                cmd.Parameters.AddWithValue("@PricePPackage", 120.50);
                cmd.Parameters.AddWithValue("@PricePUnit", 12.05);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadItems();
        }
        private void LoadItems()
        {
            string sql = "SELECT * FROM dbo.Items";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvItems.DataSource = null;
                dgvItems.AutoGenerateColumns = true;
                dgvItems.DataSource = dt;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qDentalDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.qDentalDataSet.Items);
            dgvItems.AutoGenerateColumns = true;
            LoadItems();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin loginfrm = new frmLogin(); // login form
            loginfrm.Show();
            this.Hide();
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConsumable.Text))
            {
                MessageBox.Show("Please enter an item name or ID.");
                return;
            }

            try
            {
                string query = @"SELECT * FROM dbo.Items WHERE Consumable LIKE @search OR InventoryID = @id";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Try ID search
                    int id;
                    bool isNumber = int.TryParse(txtConsumable.Text, out id);

                    cmd.Parameters.AddWithValue("@search", "%" + txtConsumable.Text + "%");
                    cmd.Parameters.AddWithValue("@id", isNumber ? id : -1);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvItems.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
