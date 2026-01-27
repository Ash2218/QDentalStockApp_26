namespace QDentalStockApp26
{
    partial class Form1
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
            System.Windows.Forms.Label overStockedLabel;
            System.Windows.Forms.Label underStockedLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label inventoryIDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.itemsTableAdapter = new QDentalStockApp26.QDentalDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new QDentalStockApp26.QDentalDataSetTableAdapters.TableAdapterManager();
            this.qDentalDataSet1 = new QDentalStockApp26.QDentalDataSet();
            this.monthlyStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyStockTableAdapter = new QDentalStockApp26.QDentalDataSetTableAdapters.MonthlyStockTableAdapter();
            this.BSvariance = new System.Windows.Forms.BindingSource(this.components);
            this.varianceTableAdapter = new QDentalStockApp26.QDentalDataSetTableAdapters.VarianceTableAdapter();
            this.overStockedCheckBox = new System.Windows.Forms.CheckBox();
            this.underStockedCheckBox = new System.Windows.Forms.CheckBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.inventoryIDTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoginForm = new System.Windows.Forms.Button();
            overStockedLabel = new System.Windows.Forms.Label();
            underStockedLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            inventoryIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSvariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // overStockedLabel
            // 
            overStockedLabel.AutoSize = true;
            overStockedLabel.Location = new System.Drawing.Point(185, 224);
            overStockedLabel.Name = "overStockedLabel";
            overStockedLabel.Size = new System.Drawing.Size(92, 16);
            overStockedLabel.TabIndex = 1;
            overStockedLabel.Text = "Over Stocked:";
            // 
            // underStockedLabel
            // 
            underStockedLabel.AutoSize = true;
            underStockedLabel.Location = new System.Drawing.Point(185, 254);
            underStockedLabel.Name = "underStockedLabel";
            underStockedLabel.Size = new System.Drawing.Size(100, 16);
            underStockedLabel.TabIndex = 3;
            underStockedLabel.Text = "Under Stocked:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(185, 282);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 16);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // inventoryIDLabel
            // 
            inventoryIDLabel.AutoSize = true;
            inventoryIDLabel.Location = new System.Drawing.Point(185, 310);
            inventoryIDLabel.Name = "inventoryIDLabel";
            inventoryIDLabel.Size = new System.Drawing.Size(80, 16);
            inventoryIDLabel.TabIndex = 7;
            inventoryIDLabel.Text = "Inventory ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.MonthlyStockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QDentalStockApp26.QDentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VarianceTableAdapter = null;
            // 
            // qDentalDataSet1
            // 
            this.qDentalDataSet1.DataSetName = "QDentalDataSet";
            this.qDentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthlyStockBindingSource
            // 
            this.monthlyStockBindingSource.DataMember = "MonthlyStock";
            this.monthlyStockBindingSource.DataSource = this.qDentalDataSet1;
            // 
            // monthlyStockTableAdapter
            // 
            this.monthlyStockTableAdapter.ClearBeforeFill = true;
            // 
            // BSvariance
            // 
            this.BSvariance.DataMember = "Variance";
            this.BSvariance.DataSource = this.qDentalDataSet1;
            // 
            // varianceTableAdapter
            // 
            this.varianceTableAdapter.ClearBeforeFill = true;
            // 
            // overStockedCheckBox
            // 
            this.overStockedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BSvariance, "OverStocked", true));
            this.overStockedCheckBox.Location = new System.Drawing.Point(291, 219);
            this.overStockedCheckBox.Name = "overStockedCheckBox";
            this.overStockedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.overStockedCheckBox.TabIndex = 2;
            this.overStockedCheckBox.Text = "checkBox1";
            this.overStockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // underStockedCheckBox
            // 
            this.underStockedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BSvariance, "UnderStocked", true));
            this.underStockedCheckBox.Location = new System.Drawing.Point(291, 249);
            this.underStockedCheckBox.Name = "underStockedCheckBox";
            this.underStockedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.underStockedCheckBox.TabIndex = 4;
            this.underStockedCheckBox.Text = "checkBox1";
            this.underStockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSvariance, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(291, 279);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(104, 22);
            this.statusTextBox.TabIndex = 6;
            // 
            // inventoryIDTextBox
            // 
            this.inventoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSvariance, "InventoryID", true));
            this.inventoryIDTextBox.Location = new System.Drawing.Point(291, 307);
            this.inventoryIDTextBox.Name = "inventoryIDTextBox";
            this.inventoryIDTextBox.Size = new System.Drawing.Size(104, 22);
            this.inventoryIDTextBox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(320, 374);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(75, 23);
            this.prev.TabIndex = 10;
            this.prev.Text = "prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.Location = new System.Drawing.Point(737, 537);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(75, 23);
            this.btnLoginForm.TabIndex = 12;
            this.btnLoginForm.Text = "Login";
            this.btnLoginForm.UseVisualStyleBackColor = true;
            this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 583);
            this.Controls.Add(this.btnLoginForm);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.button2);
            this.Controls.Add(overStockedLabel);
            this.Controls.Add(this.overStockedCheckBox);
            this.Controls.Add(underStockedLabel);
            this.Controls.Add(this.underStockedCheckBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(inventoryIDLabel);
            this.Controls.Add(this.inventoryIDTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSvariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private QDentalDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private QDentalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QDentalDataSet qDentalDataSet1;
        private System.Windows.Forms.BindingSource monthlyStockBindingSource;
        private QDentalDataSetTableAdapters.MonthlyStockTableAdapter monthlyStockTableAdapter;
        private System.Windows.Forms.BindingSource BSvariance;
        private QDentalDataSetTableAdapters.VarianceTableAdapter varianceTableAdapter;
        private System.Windows.Forms.CheckBox overStockedCheckBox;
        private System.Windows.Forms.CheckBox underStockedCheckBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox inventoryIDTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLoginForm;
    }
}

