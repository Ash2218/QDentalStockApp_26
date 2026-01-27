namespace QDentalStockApp26
{
    partial class frmItems
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConsumable = new System.Windows.Forms.TextBox();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.qDentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qDentalDataSet = new QDentalStockApp26.QDentalDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new QDentalStockApp26.QDentalDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new QDentalStockApp26.QDentalDataSetTableAdapters.TableAdapterManager();
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblEnter);
            this.panel1.Controls.Add(this.txtConsumable);
            this.panel1.Controls.Add(this.btnSearchItem);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.dgvItems);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 540);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtConsumable
            // 
            this.txtConsumable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumable.Location = new System.Drawing.Point(399, 399);
            this.txtConsumable.Name = "txtConsumable";
            this.txtConsumable.Size = new System.Drawing.Size(219, 34);
            this.txtConsumable.TabIndex = 4;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItem.Location = new System.Drawing.Point(399, 456);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(219, 41);
            this.btnSearchItem.TabIndex = 3;
            this.btnSearchItem.Text = "Search Item";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(14, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.DataSource = this.qDentalDataSetBindingSource;
            this.dgvItems.GridColor = System.Drawing.Color.White;
            this.dgvItems.Location = new System.Drawing.Point(0, 33);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(973, 324);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.qDentalDataSet;
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
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(14, 399);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(366, 29);
            this.lblEnter.TabIndex = 5;
            this.lblEnter.Text = "Enter consumable or inventory ID";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(853, 469);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 539);
            this.Controls.Add(this.panel1);
            this.Name = "frmItems";
            this.Text = "Items Form";
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource qDentalDataSetBindingSource;
        private QDentalDataSet qDentalDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private QDentalDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private QDentalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.TextBox txtConsumable;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnNext;
    }
}