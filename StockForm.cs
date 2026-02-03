using QDentalStockApp26.QDentalDataSetTableAdapters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QDentalStockApp26
{
    internal partial class StockForm : Form
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QDental;Integrated Security=True;TrustServerCertificate=True";

        private Stock stock; // Declares a private field named stock of type Stock.

        // Constructor now matches StockForm
        public StockForm(Stock stockRef) 
        {
            InitializeComponent();
            stock = stockRef;
        }

        // Event handlers updated
        private void StockForm_Load(object sender, EventArgs e)
        {
            bool exists;
            monthlyStockTableAdapter1.Fill(qDentalDataSet.MonthlyStock);
            foreach (DataRow row in qDentalDataSet.MonthlyStock.Rows)
            {
                string MonthFromTable = row.ItemArray[1].ToString();
                int IDFromTable = int.Parse(row.ItemArray[0].ToString());
                int qtyPpackOFromTable = int.Parse(row.ItemArray[3].ToString());
                int qtyPpackCFromTable = int.Parse(row.ItemArray[2].ToString());

                int unitPpackOFromTable = int.Parse(row.ItemArray[5].ToString());
                int unitPpackCFromTable = int.Parse(row.ItemArray[4].ToString());

                exists = false;
                foreach (var item in stock.GetStockList())
                {
                    if ((item.id == IDFromTable) && (item.month == MonthFromTable))
                    {
                        exists = true;
                        break; // row already exists
                    }
                }

                if (!exists)
                {
                    stock.AddStock(new Stock.MonthlyStockItem(
                        MonthFromTable, qtyPpackOFromTable, qtyPpackCFromTable,
                        unitPpackCFromTable, unitPpackOFromTable, IDFromTable));
                }
            }

            MessageBox.Show("Stock List is up to date");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are " + stock.GetStockList().Count + " items in the stock list.");
        }

        private void StockForm_Shown(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

             if (selectedIndex <= 0)
            {
                MessageBox.Show("Cannot copy from a previous month.");
                return;
            }

             string selectedMonth = comboBox1.Items[selectedIndex].ToString();
             string previousMonth = comboBox1.Items[selectedIndex - 1].ToString();
            //string selectedMonth = "january";

            string sql = @"
IF NOT EXISTS (
    SELECT 1
    FROM MonthlyStock
    WHERE InventoryID = @ItemID
      AND StockMonth = @StockMonth
)
BEGIN
    INSERT INTO MonthlyStock
    (InventoryID, StockMonth, QuantityPPackageC, QuantityPPackageO, UnitsPPackageC, UnitsPPackageO)
    VALUES
    (@ItemID, @StockMonth, @QuantityC, @QuantityO, @UnitsC, @UnitsO)
END";
            string sqlVariance = @"
IF NOT EXISTS (
    SELECT 1
    FROM VarianceTable
    WHERE InventoryID = @ItemID
      AND StockMonth = @StockMonth
)
BEGIN
    INSERT INTO VarianceTable
    (InventoryID, StockMonth, OverStocked, NeedToOrder, Status)
    VALUES
    (@ItemID, @StockMonth, 0, 0, 'Good')
END";

            MessageBox.Show("ready to edit closing stock for " + comboBox1.SelectedItem);

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlCommand cmdVar = new SqlCommand(sqlVariance, conn)) // second command
            {
                conn.Open();

                // Parameters for MonthlyStock insert
                cmd.Parameters.Add("@ItemID", SqlDbType.Int);
                cmd.Parameters.Add("@StockMonth", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@QuantityC", SqlDbType.Int);
                cmd.Parameters.Add("@QuantityO", SqlDbType.Int);
                cmd.Parameters.Add("@UnitsC", SqlDbType.Int);
                cmd.Parameters.Add("@UnitsO", SqlDbType.Int);

                // Parameters for VarianceTable insert
                cmdVar.Parameters.Add("@ItemID", SqlDbType.Int);
                cmdVar.Parameters.Add("@StockMonth", SqlDbType.VarChar, 10);

                foreach (Stock.MonthlyStockItem item in stock.GetStockList())
                {
                    if (item.month == previousMonth)
                    {
                        // Insert into MonthlyStock
                        cmd.Parameters["@ItemID"].Value = item.id;
                        cmd.Parameters["@StockMonth"].Value = selectedMonth;
                        cmd.Parameters["@QuantityC"].Value = item.qtyPpackC;
                        cmd.Parameters["@QuantityO"].Value = item.qtyPpackC;
                        cmd.Parameters["@UnitsC"].Value = item.unitsPpackC;
                        cmd.Parameters["@UnitsO"].Value = item.unitsPpackO;
                        cmd.ExecuteNonQuery();

                        // Insert into VarianceTable
                        cmdVar.Parameters["@ItemID"].Value = item.id;
                        cmdVar.Parameters["@StockMonth"].Value = selectedMonth;
                        cmdVar.ExecuteNonQuery();
                    }
                }
            }


            MessageBox.Show("Database updated");
            Form4 frm = new Form4(comboBox1.SelectedItem.ToString());
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stock.ClearStock();
            MessageBox.Show("Stock list cleared.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool MonthExists = false;
            string MonthFromTable;

            monthlyStockTableAdapter1.Fill(qDentalDataSet.MonthlyStock);
            foreach (DataRow row in qDentalDataSet.MonthlyStock.Rows)
            {
                MonthFromTable = row.ItemArray[1].ToString();

                if (MonthFromTable == comboBox1.SelectedItem.ToString())
                {
                    MonthExists = true;
                    break;
                }
            }

            if (!MonthExists)
            {
                MessageBox.Show("Stock list for " + comboBox1.SelectedItem.ToString() + " has not been created yet. Please click create stock list button");
                return;
            }

            Form4 frm = new Form4(comboBox1.SelectedItem.ToString());
            frm.Show();
        }
    }
}
