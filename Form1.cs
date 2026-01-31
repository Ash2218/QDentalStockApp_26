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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qDentalDataSet1.Variance' table. You can move, or remove it, as needed.
            this.varianceTableAdapter.Fill(this.qDentalDataSet1.Variance);
            // TODO: This line of code loads data into the 'qDentalDataSet1.MonthlyStock' table. You can move, or remove it, as needed.
            this.monthlyStockTableAdapter.Fill(this.qDentalDataSet1.MonthlyStock);
            // TODO: This line of code loads data into the 'qDentalDataSet1.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.qDentalDataSet1.Items);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //excell report code
            string connStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=QDental;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connStr);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                string query = "SELECT * FROM MonthlyStock";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);

                // Create Excel app
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true; // Makes Excel visible to user

                // Create a workbook
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = workbook.Sheets[1];
                worksheet.Name = "Stock Report";

                // Add column headers
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                    worksheet.Cells[1, i + 1].Font.Bold = true;
                }

                // Add rows
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                    }
                }

                // Autofit columns
                worksheet.Columns.AutoFit();

                MessageBox.Show("Excel report generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        //--------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Button 2 clicked!");
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qDentalDataSet1);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BSvariance.MoveNext();

        }

        private void button3_Click(object sender, EventArgs e)
        {
             BSvariance.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSvariance.EndEdit();
          varianceTableAdapter.Update(qDentalDataSet1.Variance);
            MessageBox.Show("Changes Saved");
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            frmLogin loginfrm = new frmLogin(); // login form
            loginfrm.Show();
            this.Hide();
        }
    }
}
