namespace QDentalStockApp26
{
    partial class frmConsumables
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteRec = new System.Windows.Forms.Button();
            this.bthBack = new System.Windows.Forms.Button();
            this.sedPricePUnit = new System.Windows.Forms.NumericUpDown();
            this.sedPricePPackage = new System.Windows.Forms.NumericUpDown();
            this.sedUnitsPPackage = new System.Windows.Forms.NumericUpDown();
            this.sedQuanPPackage = new System.Windows.Forms.NumericUpDown();
            this.txtConsumable = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblPricePUnit = new System.Windows.Forms.Label();
            this.lblPricePPackage = new System.Windows.Forms.Label();
            this.lblUnitsPPackage = new System.Windows.Forms.Label();
            this.lblQuantityPPackage = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblConsumableName = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedPricePUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedPricePPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedUnitsPPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedQuanPPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDeleteRec);
            this.panel1.Controls.Add(this.bthBack);
            this.panel1.Controls.Add(this.sedPricePUnit);
            this.panel1.Controls.Add(this.sedPricePPackage);
            this.panel1.Controls.Add(this.sedUnitsPPackage);
            this.panel1.Controls.Add(this.sedQuanPPackage);
            this.panel1.Controls.Add(this.txtConsumable);
            this.panel1.Controls.Add(this.rtxtDescription);
            this.panel1.Controls.Add(this.lblPricePUnit);
            this.panel1.Controls.Add(this.lblPricePPackage);
            this.panel1.Controls.Add(this.lblUnitsPPackage);
            this.panel1.Controls.Add(this.lblQuantityPPackage);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblConsumableName);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.dgvItems);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 604);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteRec
            // 
            this.btnDeleteRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRec.Location = new System.Drawing.Point(889, 557);
            this.btnDeleteRec.Name = "btnDeleteRec";
            this.btnDeleteRec.Size = new System.Drawing.Size(163, 41);
            this.btnDeleteRec.TabIndex = 39;
            this.btnDeleteRec.Text = "Delete Item";
            this.btnDeleteRec.UseVisualStyleBackColor = true;
            this.btnDeleteRec.Click += new System.EventHandler(this.btnDeleteRec_Click);
            // 
            // bthBack
            // 
            this.bthBack.Location = new System.Drawing.Point(0, 0);
            this.bthBack.Name = "bthBack";
            this.bthBack.Size = new System.Drawing.Size(75, 23);
            this.bthBack.TabIndex = 38;
            this.bthBack.Text = "Back";
            this.bthBack.UseVisualStyleBackColor = true;
            this.bthBack.Click += new System.EventHandler(this.bthBack_Click);
            // 
            // sedPricePUnit
            // 
            this.sedPricePUnit.DecimalPlaces = 2;
            this.sedPricePUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sedPricePUnit.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sedPricePUnit.Location = new System.Drawing.Point(266, 481);
            this.sedPricePUnit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sedPricePUnit.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sedPricePUnit.Name = "sedPricePUnit";
            this.sedPricePUnit.Size = new System.Drawing.Size(111, 34);
            this.sedPricePUnit.TabIndex = 37;
            this.sedPricePUnit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sedPricePPackage
            // 
            this.sedPricePPackage.DecimalPlaces = 2;
            this.sedPricePPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sedPricePPackage.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sedPricePPackage.Location = new System.Drawing.Point(266, 445);
            this.sedPricePPackage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sedPricePPackage.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sedPricePPackage.Name = "sedPricePPackage";
            this.sedPricePPackage.Size = new System.Drawing.Size(111, 34);
            this.sedPricePPackage.TabIndex = 36;
            this.sedPricePPackage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sedUnitsPPackage
            // 
            this.sedUnitsPPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sedUnitsPPackage.Location = new System.Drawing.Point(266, 406);
            this.sedUnitsPPackage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sedUnitsPPackage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sedUnitsPPackage.Name = "sedUnitsPPackage";
            this.sedUnitsPPackage.Size = new System.Drawing.Size(111, 34);
            this.sedUnitsPPackage.TabIndex = 35;
            this.sedUnitsPPackage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sedQuanPPackage
            // 
            this.sedQuanPPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sedQuanPPackage.Location = new System.Drawing.Point(266, 371);
            this.sedQuanPPackage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sedQuanPPackage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sedQuanPPackage.Name = "sedQuanPPackage";
            this.sedQuanPPackage.Size = new System.Drawing.Size(111, 34);
            this.sedQuanPPackage.TabIndex = 34;
            this.sedQuanPPackage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtConsumable
            // 
            this.txtConsumable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumable.Location = new System.Drawing.Point(258, 331);
            this.txtConsumable.Name = "txtConsumable";
            this.txtConsumable.Size = new System.Drawing.Size(175, 34);
            this.txtConsumable.TabIndex = 33;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(619, 328);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(273, 48);
            this.rtxtDescription.TabIndex = 32;
            this.rtxtDescription.Text = "";
            // 
            // lblPricePUnit
            // 
            this.lblPricePUnit.AutoSize = true;
            this.lblPricePUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePUnit.Location = new System.Drawing.Point(19, 487);
            this.lblPricePUnit.Name = "lblPricePUnit";
            this.lblPricePUnit.Size = new System.Drawing.Size(192, 29);
            this.lblPricePUnit.TabIndex = 31;
            this.lblPricePUnit.Text = "Price per Unit(R)";
            // 
            // lblPricePPackage
            // 
            this.lblPricePPackage.AutoSize = true;
            this.lblPricePPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePPackage.Location = new System.Drawing.Point(19, 451);
            this.lblPricePPackage.Name = "lblPricePPackage";
            this.lblPricePPackage.Size = new System.Drawing.Size(244, 29);
            this.lblPricePPackage.TabIndex = 30;
            this.lblPricePPackage.Text = "Price per Package(R)";
            // 
            // lblUnitsPPackage
            // 
            this.lblUnitsPPackage.AutoSize = true;
            this.lblUnitsPPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitsPPackage.Location = new System.Drawing.Point(19, 412);
            this.lblUnitsPPackage.Name = "lblUnitsPPackage";
            this.lblUnitsPPackage.Size = new System.Drawing.Size(209, 29);
            this.lblUnitsPPackage.TabIndex = 29;
            this.lblUnitsPPackage.Text = "Units per Package";
            // 
            // lblQuantityPPackage
            // 
            this.lblQuantityPPackage.AutoSize = true;
            this.lblQuantityPPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityPPackage.Location = new System.Drawing.Point(19, 374);
            this.lblQuantityPPackage.Name = "lblQuantityPPackage";
            this.lblQuantityPPackage.Size = new System.Drawing.Size(242, 29);
            this.lblQuantityPPackage.TabIndex = 28;
            this.lblQuantityPPackage.Text = "Quantity per Package";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(478, 331);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 29);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Description";
            // 
            // lblConsumableName
            // 
            this.lblConsumableName.AutoSize = true;
            this.lblConsumableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumableName.Location = new System.Drawing.Point(18, 328);
            this.lblConsumableName.Name = "lblConsumableName";
            this.lblConsumableName.Size = new System.Drawing.Size(215, 29);
            this.lblConsumableName.TabIndex = 26;
            this.lblConsumableName.Text = "Consumable name";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(231, 557);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(163, 41);
            this.btnAddItem.TabIndex = 25;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.GridColor = System.Drawing.Color.White;
            this.dgvItems.Location = new System.Drawing.Point(79, -9);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(973, 324);
            this.dgvItems.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(547, 557);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 41);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmConsumables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 628);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsumables";
            this.Text = "Consumables";
            this.Load += new System.EventHandler(this.Consumables_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedPricePUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedPricePPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedUnitsPPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedQuanPPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.NumericUpDown sedPricePUnit;
        private System.Windows.Forms.NumericUpDown sedPricePPackage;
        private System.Windows.Forms.NumericUpDown sedUnitsPPackage;
        private System.Windows.Forms.NumericUpDown sedQuanPPackage;
        private System.Windows.Forms.TextBox txtConsumable;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblPricePUnit;
        private System.Windows.Forms.Label lblPricePPackage;
        private System.Windows.Forms.Label lblUnitsPPackage;
        private System.Windows.Forms.Label lblQuantityPPackage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblConsumableName;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button bthBack;
        private System.Windows.Forms.Button btnDeleteRec;
        private System.Windows.Forms.Button btnUpdate;
    }
}