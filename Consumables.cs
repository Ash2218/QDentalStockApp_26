using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QDentalStockApp26
{
    public partial class frmConsumables : Form
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=QDental;Trusted_Connection=True;";
        public frmConsumables()
        {
            InitializeComponent();
            dgvItems.SelectionChanged += DgvItems_SelectionChanged;

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

        private void Consumables_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qDentalDataSet.Items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter.Fill(this.qDentalDataSet.Items);
            dgvItems.AutoGenerateColumns = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.MultiSelect = false;
            LoadItems();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtConsumable.Text))
            {
                MessageBox.Show(
                    "Please enter a consumable name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtConsumable.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtxtDescription.Text))
            {
                MessageBox.Show(
                    "Please enter a description.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                rtxtDescription.Focus();
                return;
            }

            String consumableName = txtConsumable.Text.Trim();
            String description = rtxtDescription.Text.Trim();
            int quantityPerPackage = (int) sedQuanPPackage.Value;
            int unitsPerPackage = (int) sedUnitsPPackage.Value;
            decimal pricePerPackage = sedPricePPackage.Value;
            decimal pricePerUnit = sedPricePUnit.Value;
            int newID;

            // Confirmation first
            DialogResult result = MessageBox.Show( "Are you sure you want to add "+ consumableName +"?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return; //user didnt click yes(no or closed the messagebox)
            }

            string sql = @" INSERT INTO dbo.Items(Consumable,Description,QuantityPPackage,UnitsPPackage,PricePPackage,PricePUnit) VALUES
            (@Consumable,@Description,@QuantityPPackage,@UnitsPPackage,@PricePPackage,@PricePUnit); 
            SELECT SCOPE_IDENTITY(); ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Consumable", consumableName);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@QuantityPPackage", quantityPerPackage);
                cmd.Parameters.AddWithValue("@UnitsPPackage", unitsPerPackage);
                cmd.Parameters.AddWithValue("@PricePPackage", pricePerPackage);
                cmd.Parameters.AddWithValue("@PricePUnit", pricePerUnit);

                conn.Open();
                newID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            LoadItems();

            // loaded item
            MessageBox.Show($"{consumableName} (Inventory ID: {newID}) added successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.ActiveControl = null;
        }

        private void bthBack_Click(object sender, EventArgs e)
        {
            frmItems itemsfrm = new frmItems();
            itemsfrm.Show();
            this.Hide();
        }

        private void btnDeleteRec_Click(object sender, EventArgs e)
        {
           
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvItems.SelectedRows[0];

            int inventoryId = Convert.ToInt32(row.Cells["InventoryID"].Value);
            string consumableName = row.Cells["Consumable"].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete \"{consumableName}\" (ID: {inventoryId})?","Confirm Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            string sql = "DELETE FROM dbo.Items WHERE InventoryID = @InventoryID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@InventoryID", inventoryId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadItems();

            MessageBox.Show("Item deleted successfully.","Deleted", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.ActiveControl = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Make sure a row is selected
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvItems.SelectedRows[0];

            // Get the InventoryID of the selected row
            int inventoryId = Convert.ToInt32(row.Cells["InventoryID"].Value);

            // Optional: Prompt user for confirmation
            string consumableName = txtConsumable.Text.Trim();
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to update \"{consumableName}\" (ID: {inventoryId})?","Confirm Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }
            // Get updated values from your form controls
            string updatedConsumable = txtConsumable.Text.Trim();
            string updatedDescription = rtxtDescription.Text.Trim();
            int updatedQuantityPPackage = (int)sedQuanPPackage.Value;
            int updatedUnitsPPackage = (int)sedUnitsPPackage.Value;
            decimal updatedPricePPackage = sedPricePPackage.Value;
            decimal updatedPricePUnit = sedPricePUnit.Value;

            // SQL Update command
            string sql = @"UPDATE dbo.Items SET Consumable = @Consumable,Description = @Description,QuantityPPackage = @QuantityPPackage,UnitsPPackage = @UnitsPPackage,PricePPackage = @PricePPackage,PricePUnit = @PricePUnit WHERE InventoryID = @InventoryID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Consumable", updatedConsumable);
                cmd.Parameters.AddWithValue("@Description", updatedDescription);
                cmd.Parameters.AddWithValue("@QuantityPPackage", updatedQuantityPPackage);
                cmd.Parameters.AddWithValue("@UnitsPPackage", updatedUnitsPPackage);
                cmd.Parameters.AddWithValue("@PricePPackage", updatedPricePPackage);
                cmd.Parameters.AddWithValue("@PricePUnit", updatedPricePUnit);
                cmd.Parameters.AddWithValue("@InventoryID", inventoryId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadItems(); // Refresh the DataGridView

                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.ActiveControl = null;
            }
        }

        private void DgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dgvItems.SelectedRows[0];

            // Populate the controls with the selected row's values
            txtConsumable.Text = row.Cells["Consumable"].Value?.ToString() ?? "";
            rtxtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";

            // For numeric controls, try parsing values
            if (int.TryParse(row.Cells["QuantityPPackage"].Value?.ToString(), out int quantity))
                sedQuanPPackage.Value = quantity;
            else
                sedQuanPPackage.Value = 0;

            if (int.TryParse(row.Cells["UnitsPPackage"].Value?.ToString(), out int units))
                sedUnitsPPackage.Value = units;
            else
                sedUnitsPPackage.Value = 0;

            if (decimal.TryParse(row.Cells["PricePPackage"].Value?.ToString(), out decimal pricePackage))
                sedPricePPackage.Value = pricePackage;
            else
                sedPricePPackage.Value = 0;

            if (decimal.TryParse(row.Cells["PricePUnit"].Value?.ToString(), out decimal priceUnit))
                sedPricePUnit.Value = priceUnit;
            else
                sedPricePUnit.Value = 0;
        }


    }

}
