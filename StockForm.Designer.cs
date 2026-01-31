namespace QDentalStockApp26
{
    partial class StockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.qDentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qDentalDataSet = new QDentalStockApp26.QDentalDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.monthlyStockTableAdapter1 = new QDentalStockApp26.QDentalDataSetTableAdapters.MonthlyStockTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.monthlyStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new QDentalStockApp26.QDentalDataSetTableAdapters.TableAdapterManager();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qDentalDataSetBindingSource
            // 
            this.qDentalDataSetBindingSource.DataSource = this.qDentalDataSet;
            this.qDentalDataSetBindingSource.Position = 0;
            // 
            // qDentalDataSet
            // 
            this.qDentalDataSet.DataSetName = "QDentalDataSet";
            this.qDentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthlyStockTableAdapter1
            // 
            this.monthlyStockTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(500, 123);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create Stock for selected  month";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "january",
            "february",
            "march",
            "april",
            "may",
            "june",
            "july",
            "august",
            "september",
            "october",
            "november",
            "december"});
            this.comboBox1.Location = new System.Drawing.Point(290, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(500, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Clear stock list";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // monthlyStockBindingSource
            // 
            this.monthlyStockBindingSource.DataMember = "MonthlyStock";
            this.monthlyStockBindingSource.DataSource = this.qDentalDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.MonthlyStockTableAdapter = this.monthlyStockTableAdapter1;
            this.tableAdapterManager.UpdateOrder = QDentalStockApp26.QDentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VarianceTableAdapter = null;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(500, 122);
            this.button4.TabIndex = 5;
            this.button4.Text = "edit stock for selected month";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 406);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.Shown += new System.EventHandler(this.StockForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource qDentalDataSetBindingSource;
        private QDentalDataSet qDentalDataSet;
        private System.Windows.Forms.Button button1;
        private QDentalDataSetTableAdapters.MonthlyStockTableAdapter monthlyStockTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource monthlyStockBindingSource;
        private QDentalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button4;
    }
}
