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
        private void monthlyStockDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = monthlyStockDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Skip read-only cells
            if (cell.ReadOnly) return;

            // Highlight edited cell
            cell.Style.BackColor = Color.LightYellow;

            // Optional: mark the row as edited for later save
            monthlyStockDataGridView.Rows[e.RowIndex].Tag = "Edited";
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

            string connStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=QDental;Integrated Security=True;Encrypt=False";
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
        SELECT *
        FROM MonthlyStock
        WHERE StockMonth = @month";

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

                // ----------- TITLE -----------
                worksheet.Cells[1, 1] = "Monthly Stock Report";
                worksheet.Range["A1:F1"].Merge();
                worksheet.Cells[1, 1].Font.Bold = true;
                worksheet.Cells[1, 1].Font.Size = 16;
                worksheet.Cells[1, 1].HorizontalAlignment =
                    Excel.XlHAlign.xlHAlignCenter;

                worksheet.Cells[2, 1] = $"Stock Month: {monthFilter}";
                worksheet.Range["A2:F2"].Merge();
                worksheet.Cells[2, 1].Font.Italic = true;

                // ----------- COLUMN ORDER (Excel → DataTable) -----------
                // Excel order: ID, Month, PacksOpening, UnitsOpening, PacksClosing, UnitsClosing
                int[] columnOrder = { 0, 1, 3, 5, 2, 4 };

                // ----------- CUSTOM HEADERS -----------
                string[] headers =
                {
        "Item ID",
        "Stock Month",
        "Packs Opening",
        "Units Opening",
        "Packs Closing",
        "Units Closing"
    };

                int headerRow = 3;

                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cells[headerRow, i + 1] = headers[i];
                    worksheet.Cells[headerRow, i + 1].Font.Bold = true;
                    worksheet.Cells[headerRow, i + 1].Interior.Color =
                        Excel.XlRgbColor.rgbLightGray;
                    worksheet.Cells[headerRow, i + 1].Borders.LineStyle =
                        Excel.XlLineStyle.xlContinuous;
                }

                // ----------- DATA -----------
                int startRow = headerRow + 1;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < columnOrder.Length; j++)
                    {
                        worksheet.Cells[startRow + i, j + 1] =
                            dt.Rows[i][columnOrder[j]];
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
        }
    }
}
