namespace QDentalStockApp26
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.qDentalDataSet = new QDentalStockApp26.QDentalDataSet();
            this.monthlyStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyStockTableAdapter = new QDentalStockApp26.QDentalDataSetTableAdapters.MonthlyStockTableAdapter();
            this.tableAdapterManager = new QDentalStockApp26.QDentalDataSetTableAdapters.TableAdapterManager();
            this.monthlyStockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.monthlyStockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.monthlyStockDataGridView = new System.Windows.Forms.DataGridView();
            this.InventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPPackageC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPPackageO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsPPackageC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsPPackageO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockBindingNavigator)).BeginInit();
            this.monthlyStockBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qDentalDataSet
            // 
            this.qDentalDataSet.DataSetName = "QDentalDataSet";
            this.qDentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthlyStockBindingSource
            // 
            this.monthlyStockBindingSource.DataMember = "MonthlyStock";
            this.monthlyStockBindingSource.DataSource = this.qDentalDataSet;
            // 
            // monthlyStockTableAdapter
            // 
            this.monthlyStockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.MonthlyStockTableAdapter = this.monthlyStockTableAdapter;
            this.tableAdapterManager.UpdateOrder = QDentalStockApp26.QDentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VarianceTableAdapter = null;
            // 
            // monthlyStockBindingNavigator
            // 
            this.monthlyStockBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.monthlyStockBindingNavigator.BindingSource = this.monthlyStockBindingSource;
            this.monthlyStockBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.monthlyStockBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.monthlyStockBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.monthlyStockBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.monthlyStockBindingNavigatorSaveItem});
            this.monthlyStockBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.monthlyStockBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.monthlyStockBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.monthlyStockBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.monthlyStockBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.monthlyStockBindingNavigator.Name = "monthlyStockBindingNavigator";
            this.monthlyStockBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.monthlyStockBindingNavigator.Size = new System.Drawing.Size(1353, 27);
            this.monthlyStockBindingNavigator.TabIndex = 0;
            this.monthlyStockBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // monthlyStockBindingNavigatorSaveItem
            // 
            this.monthlyStockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.monthlyStockBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("monthlyStockBindingNavigatorSaveItem.Image")));
            this.monthlyStockBindingNavigatorSaveItem.Name = "monthlyStockBindingNavigatorSaveItem";
            this.monthlyStockBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.monthlyStockBindingNavigatorSaveItem.Text = "Save Data";
            this.monthlyStockBindingNavigatorSaveItem.Click += new System.EventHandler(this.monthlyStockBindingNavigatorSaveItem_Click);
            // 
            // monthlyStockDataGridView
            // 
            this.monthlyStockDataGridView.AutoGenerateColumns = false;
            this.monthlyStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyStockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryID,
            this.StockMonth,
            this.QuantityPPackageC,
            this.QuantityPPackageO,
            this.UnitsPPackageC,
            this.UnitsPPackageO});
            this.monthlyStockDataGridView.DataSource = this.monthlyStockBindingSource;
            this.monthlyStockDataGridView.Location = new System.Drawing.Point(47, 152);
            this.monthlyStockDataGridView.Name = "monthlyStockDataGridView";
            this.monthlyStockDataGridView.RowHeadersWidth = 51;
            this.monthlyStockDataGridView.RowTemplate.Height = 24;
            this.monthlyStockDataGridView.Size = new System.Drawing.Size(976, 250);
            this.monthlyStockDataGridView.TabIndex = 1;
            // 
            // InventoryID
            // 
            this.InventoryID.DataPropertyName = "InventoryID";
            this.InventoryID.HeaderText = "InventoryID";
            this.InventoryID.MinimumWidth = 6;
            this.InventoryID.Name = "InventoryID";
            this.InventoryID.Width = 125;
            // 
            // StockMonth
            // 
            this.StockMonth.DataPropertyName = "StockMonth";
            this.StockMonth.HeaderText = "StockMonth";
            this.StockMonth.MinimumWidth = 6;
            this.StockMonth.Name = "StockMonth";
            this.StockMonth.Width = 125;
            // 
            // QuantityPPackageC
            // 
            this.QuantityPPackageC.DataPropertyName = "QuantityPPackageC";
            this.QuantityPPackageC.HeaderText = "Quantity/Package";
            this.QuantityPPackageC.MinimumWidth = 6;
            this.QuantityPPackageC.Name = "QuantityPPackageC";
            this.QuantityPPackageC.Width = 125;
            // 
            // QuantityPPackageO
            // 
            this.QuantityPPackageO.DataPropertyName = "QuantityPPackageO";
            this.QuantityPPackageO.HeaderText = "Quantity/Package";
            this.QuantityPPackageO.MinimumWidth = 6;
            this.QuantityPPackageO.Name = "QuantityPPackageO";
            this.QuantityPPackageO.Width = 125;
            // 
            // UnitsPPackageC
            // 
            this.UnitsPPackageC.DataPropertyName = "UnitsPPackageC";
            this.UnitsPPackageC.HeaderText = "Units/Package";
            this.UnitsPPackageC.MinimumWidth = 6;
            this.UnitsPPackageC.Name = "UnitsPPackageC";
            this.UnitsPPackageC.Width = 125;
            // 
            // UnitsPPackageO
            // 
            this.UnitsPPackageO.DataPropertyName = "UnitsPPackageO";
            this.UnitsPPackageO.HeaderText = "Units/Package";
            this.UnitsPPackageO.MinimumWidth = 6;
            this.UnitsPPackageO.Name = "UnitsPPackageO";
            this.UnitsPPackageO.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1266, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "back to form 3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Opening";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(782, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Closing";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1266, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthlyStockDataGridView);
            this.Controls.Add(this.monthlyStockBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Shown += new System.EventHandler(this.Form4_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qDentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockBindingNavigator)).EndInit();
            this.monthlyStockBindingNavigator.ResumeLayout(false);
            this.monthlyStockBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QDentalDataSet qDentalDataSet;
        private System.Windows.Forms.BindingSource monthlyStockBindingSource;
        private QDentalDataSetTableAdapters.MonthlyStockTableAdapter monthlyStockTableAdapter;
        private QDentalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator monthlyStockBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton monthlyStockBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView monthlyStockDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPPackageC;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPPackageO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsPPackageC;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsPPackageO;
        private System.Windows.Forms.Button button2;
    }
}