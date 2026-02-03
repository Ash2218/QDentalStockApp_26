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
using Excel = Microsoft.Office.Interop.Excel;

namespace QDentalStockApp26
{
    public partial class Form4 : Form

    {
        private string monthFilter;
        public Form4(string month)
        {
            InitializeComponent();
            monthFilter = month;
        }
        private string connStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=QDental;Integrated Security=True;Encrypt=False";

        private void UpdateVarianceValues()
        {
            //how variance will change
            // Update variance values using the new VarianceTable
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
UPDATE V
SET
    V.OverStocked =
        CASE
            WHEN MS.QuantityPPackageC > I.QuantityPPackage THEN 1
            ELSE 0
        END,

    V.NeedToOrder =
        CASE
            WHEN MS.QuantityPPackageC < I.QuantityPPackage THEN 1
            ELSE 0
        END,

    V.Status =
        CASE
            WHEN MS.QuantityPPackageC < I.QuantityPPackage THEN 'Not Good'
            ELSE 'Good'
        END
FROM VarianceTable V
JOIN Items I
    ON V.InventoryID = I.InventoryID
JOIN MonthlyStock MS
    ON V.InventoryID = MS.InventoryID
   AND V.StockMonth = MS.StockMonth
WHERE MS.StockMonth = @monthFilter;
        ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@monthFilter", monthFilter);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
        private void monthlyStockDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = monthlyStockDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Skip read-only cells
            if (cell.ReadOnly) return;

            // Highlight edited cell
            cell.Style.BackColor = Color.LightYellow;

            // Optional: mark the cell as edited for later save
            cell.Tag = "Edited";   //track per-cell
        }

        private void monthlyStockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monthlyStockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qDentalDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qDentalDataSet.MonthlyStock' table. You can move, or remove it, as needed.
            this.monthlyStockTableAdapter.Fill(this.qDentalDataSet.MonthlyStock);

            monthlyStockBindingSource.Filter =
                "StockMonth = '" + monthFilter + "'";

            monthlyStockDataGridView.DataSource = monthlyStockBindingSource;

            // NOW columns exist
           

            monthlyStockDataGridView.Size = new Size(900, 600);
            monthlyStockDataGridView.Columns["StockMonth"].DisplayIndex = 0;
            monthlyStockDataGridView.Columns["InventoryID"].DisplayIndex = 1;
            monthlyStockDataGridView.Columns["QuantityPPackageC"].DisplayIndex = 4;
            monthlyStockDataGridView.Columns["UnitsPPackageC"].DisplayIndex = 5;
            monthlyStockDataGridView.Columns["QuantityPPackageO"].DisplayIndex = 2;
            monthlyStockDataGridView.Columns["UnitsPPackageO"].DisplayIndex = 3;
     //----------------------------------------------------------------------------------------
            monthlyStockDataGridView.Columns["StockMonth"].ReadOnly = true;
            monthlyStockDataGridView.Columns["InventoryID"].ReadOnly = true;
            monthlyStockDataGridView.Columns["QuantityPPackageO"].ReadOnly = true;
            monthlyStockDataGridView.Columns["UnitsPPackageO"].ReadOnly = true;
            // Editable columns
            monthlyStockDataGridView.Columns["QuantityPPackageC"].ReadOnly = false;

            monthlyStockDataGridView.Columns["UnitsPPackageC"].ReadOnly = false;

            //
            // **Hook the CellEndEdit event here**
            monthlyStockDataGridView.CellEndEdit += monthlyStockDataGridView_CellEndEdit;
            //need to clear all when saved
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();          // create shared data
            StockForm frm = new StockForm(stock);

            
            frm.Show();
            this.Hide();
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
           
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthlyStockBindingSource.EndEdit();
            monthlyStockTableAdapter.Update(qDentalDataSet.MonthlyStock);
            // change to green for successfully saved
            foreach (DataGridViewRow row in monthlyStockDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Tag?.ToString() == "Edited")
                    {
                        cell.Style.BackColor = Color.LightGreen;
                        cell.Tag = "Saved";
                    }
                }
            }
            MessageBox.Show("Data saved");

            //excel sheet generation
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
SELECT 
    MS.InventoryID,
    I.Description AS ItemName,
    MS.QuantityPPackageO AS PacksOpening,
    MS.UnitsPPackageO AS UnitsOpening,
    MS.QuantityPPackageC AS PacksClosing,
    MS.UnitsPPackageC AS UnitsClosing,
    (MS.QuantityPPackageC * I.PricePPackage) AS ClosingValue,
    (MS.QuantityPPackageO * I.PricePPackage) AS OpeningValue,
    CASE
        WHEN (MS.QuantityPPackageC * I.PricePPackage) > (MS.QuantityPPackageO * I.PricePPackage) THEN 'Stock increased'
        WHEN (MS.QuantityPPackageC * I.PricePPackage) < (MS.QuantityPPackageO * I.PricePPackage) THEN 'Stock decreased'
        ELSE 'Stayed the same'
    END AS Variance,
    V.OverStocked,
    V.NeedToOrder,
    V.Status,
    (I.QuantityPPackage - MS.QuantityPPackageC) AS PacksDoIOrder,
    (I.UnitsPPackage - MS.UnitsPPackageC) AS UnitsDoIOrder
FROM MonthlyStock MS
JOIN Items I ON MS.InventoryID = I.InventoryID
LEFT JOIN VarianceTable V 
    ON MS.InventoryID = V.InventoryID 
    AND MS.StockMonth = V.StockMonth
WHERE MS.StockMonth = @month
ORDER BY I.Description;
";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@month", monthFilter);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }

                // ----------------- EXCEL -----------------
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = workbook.Sheets[1];
                worksheet.Name = "Stock Report";

                // ----------- TITLE / HEADER -----------
                worksheet.Cells[1, 1] = "Monthly Stock Report";
                worksheet.Range["A1:N1"].Merge();  // Adjust width for all columns
                worksheet.Cells[1, 1].Font.Bold = true;
                worksheet.Cells[1, 1].Font.Size = 16;
                worksheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                worksheet.Cells[2, 1] = $"Stock Month: {monthFilter}";
                worksheet.Range["A2:N2"].Merge();
                worksheet.Cells[2, 1].Font.Italic = true;

                // ----------- COLUMN HEADERS -----------
                int headerRow = 3;

                string[] headers =
                {
        "Item ID",
        "Item Name",
        "Packs Opening",
        "Units Opening",
        "Packs Closing",
        "Units Closing",
        "Closing Value",
        "Opening Value",
        "Variance",
        "OverStocked",
        "NeedToOrder",
        "Status",
        "Packs Do I Order?",
        "Units Do I Order?"
    };

                // Map columns from DataTable to Excel (0-based indexes)
               // int[] columnOrder = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
                int[] columnOrder = { 0, 1, 3, 5, 2, 4, 6, 7, 8, 9, 10, 11,12,13 };
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cells[headerRow, i + 1] = headers[i];
                    worksheet.Cells[headerRow, i + 1].Font.Bold = true;
                    worksheet.Cells[headerRow, i + 1].Interior.Color = Excel.XlRgbColor.rgbLightGray;
                    worksheet.Cells[headerRow, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }

                // ----------- DATA -----------
                int startRow = headerRow + 1;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < columnOrder.Length; j++)
                    {
                        worksheet.Cells[startRow + i, j + 1] = dt.Rows[i][columnOrder[j]];
                    }

                    // Highlight row if NeedToOrder = 1
                    bool needToOrder = dt.Rows[i]["NeedToOrder"] != DBNull.Value && Convert.ToInt32(dt.Rows[i]["NeedToOrder"]) == 1;
                    if (needToOrder)
                    {
                        for (int col = 1; col <= columnOrder.Length; col++)
                        {
                            worksheet.Cells[startRow + i, col].Interior.Color = Excel.XlRgbColor.rgbLightSalmon;
                        }
                    }
                }

                // ----------- FINAL TOUCHES -----------
                worksheet.Columns.AutoFit();
                worksheet.Application.ActiveWindow.SplitRow = headerRow;
                worksheet.Application.ActiveWindow.FreezePanes = true;

                MessageBox.Show("Excel report generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            UpdateVarianceValues();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            monthlyStockBindingSource.EndEdit();
            monthlyStockTableAdapter.Update(qDentalDataSet.MonthlyStock);

            //change to green to show successful save
            foreach (DataGridViewRow row in monthlyStockDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Tag?.ToString() == "Edited")
                    {
                        cell.Style.BackColor = Color.LightGreen;
                        cell.Tag = "Saved";
                    }
                }
            }

            UpdateVarianceValues();
        MessageBox.Show("Data saved successfully and Variance updated.");

        }

        private void Form4_Leave(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool hasUnsavedChanges = monthlyStockDataGridView.Rows
           .Cast<DataGridViewRow>()
           .SelectMany(r => r.Cells.Cast<DataGridViewCell>())
           .Any(c => c.Tag?.ToString() == "Edited");

            if (hasUnsavedChanges)
            {
                var result = MessageBox.Show(
                    "You have unsaved changes. Are you sure you want to exit?",
                    "Unsaved Data",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

            // Reset colours when exiting
            foreach (DataGridViewRow row in monthlyStockDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Tag = null;
                }
            }

        }
    }
}
