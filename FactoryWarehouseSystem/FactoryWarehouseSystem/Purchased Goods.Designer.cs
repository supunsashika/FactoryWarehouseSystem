namespace FactoryWarehouseSystem
{
    partial class Purchased_Goods
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
            this.btnIssueInv = new System.Windows.Forms.Button();
            this.btnCancal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmbItemCode = new System.Windows.Forms.ComboBox();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lankaTiles2DataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lankaTiles2DataSet5 = new FactoryWarehouseSystem.LankaTiles2DataSet5();
            this.cmbItemID = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSupName = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGRNID = new System.Windows.Forms.TextBox();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.supplierTableAdapter = new FactoryWarehouseSystem.LankaTiles2DataSet5TableAdapters.SupplierTableAdapter();
            this.warehousesTableAdapter = new FactoryWarehouseSystem.LankaTiles2DataSet5TableAdapters.WarehousesTableAdapter();
            this.itemTableAdapter = new FactoryWarehouseSystem.LankaTiles2DataSet5TableAdapters.itemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lankaTiles2DataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lankaTiles2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIssueInv
            // 
            this.btnIssueInv.Location = new System.Drawing.Point(342, 421);
            this.btnIssueInv.Name = "btnIssueInv";
            this.btnIssueInv.Size = new System.Drawing.Size(87, 29);
            this.btnIssueInv.TabIndex = 19;
            this.btnIssueInv.Text = "Issue Invoice";
            this.btnIssueInv.UseVisualStyleBackColor = true;
            this.btnIssueInv.Click += new System.EventHandler(this.btnIssueInv_Click);
            // 
            // btnCancal
            // 
            this.btnCancal.Location = new System.Drawing.Point(261, 421);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(75, 29);
            this.btnCancal.TabIndex = 18;
            this.btnCancal.Text = "Cancal";
            this.btnCancal.UseVisualStyleBackColor = true;
            this.btnCancal.Click += new System.EventHandler(this.btnCancal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(417, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(291, 76);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.cmbItemCode);
            this.groupBox1.Controls.Add(this.cmbItemID);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 111);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Items";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Item Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item ID";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(96, 78);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(157, 20);
            this.txtQty.TabIndex = 2;
            // 
            // cmbItemCode
            // 
            this.cmbItemCode.DataSource = this.itemBindingSource1;
            this.cmbItemCode.DisplayMember = "itemCode";
            this.cmbItemCode.FormattingEnabled = true;
            this.cmbItemCode.Location = new System.Drawing.Point(96, 51);
            this.cmbItemCode.Name = "cmbItemCode";
            this.cmbItemCode.Size = new System.Drawing.Size(157, 21);
            this.cmbItemCode.TabIndex = 1;
            this.cmbItemCode.ValueMember = "itemCode";
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "item";
            this.itemBindingSource1.DataSource = this.lankaTiles2DataSet5BindingSource;
            // 
            // lankaTiles2DataSet5BindingSource
            // 
            this.lankaTiles2DataSet5BindingSource.DataSource = this.lankaTiles2DataSet5;
            this.lankaTiles2DataSet5BindingSource.Position = 0;
            // 
            // lankaTiles2DataSet5
            // 
            this.lankaTiles2DataSet5.DataSetName = "LankaTiles2DataSet5";
            this.lankaTiles2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbItemID
            // 
            this.cmbItemID.DataSource = this.itemBindingSource;
            this.cmbItemID.DisplayMember = "itemID";
            this.cmbItemID.FormattingEnabled = true;
            this.cmbItemID.Location = new System.Drawing.Point(96, 24);
            this.cmbItemID.Name = "cmbItemID";
            this.cmbItemID.Size = new System.Drawing.Size(157, 21);
            this.cmbItemID.TabIndex = 0;
            this.cmbItemID.ValueMember = "itemID";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.lankaTiles2DataSet5BindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(111, 88);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(318, 20);
            this.txtDate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Supplier ID";
            // 
            // cmbDestination
            // 
            this.cmbDestination.DataSource = this.warehousesBindingSource;
            this.cmbDestination.DisplayMember = "location";
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(111, 114);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(318, 21);
            this.cmbDestination.TabIndex = 21;
            this.cmbDestination.ValueMember = "location";
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.lankaTiles2DataSet5BindingSource;
            // 
            // cmbSupName
            // 
            this.cmbSupName.DataSource = this.supplierBindingSource;
            this.cmbSupName.DisplayMember = "supName";
            this.cmbSupName.FormattingEnabled = true;
            this.cmbSupName.Location = new System.Drawing.Point(111, 61);
            this.cmbSupName.Name = "cmbSupName";
            this.cmbSupName.Size = new System.Drawing.Size(318, 21);
            this.cmbSupName.TabIndex = 23;
            this.cmbSupName.ValueMember = "supName";
            this.cmbSupName.SelectedIndexChanged += new System.EventHandler(this.cmbSupName_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.lankaTiles2DataSet5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Supplier Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "GRNID";
            // 
            // txtGRNID
            // 
            this.txtGRNID.Enabled = false;
            this.txtGRNID.Location = new System.Drawing.Point(111, 8);
            this.txtGRNID.Name = "txtGRNID";
            this.txtGRNID.Size = new System.Drawing.Size(318, 20);
            this.txtGRNID.TabIndex = 25;
            // 
            // txtSupID
            // 
            this.txtSupID.Enabled = false;
            this.txtSupID.Location = new System.Drawing.Point(111, 35);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(318, 20);
            this.txtSupID.TabIndex = 26;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // Purchased_Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 462);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGRNID);
            this.Controls.Add(this.cmbSupName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.btnIssueInv);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Name = "Purchased_Goods";
            this.Text = "Purchased Goods";
            this.Load += new System.EventHandler(this.Purchased_Goods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lankaTiles2DataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lankaTiles2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssueInv;
        private System.Windows.Forms.Button btnCancal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmbItemCode;
        private System.Windows.Forms.ComboBox cmbItemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.ComboBox cmbSupName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGRNID;
        private System.Windows.Forms.TextBox txtSupID;
        private LankaTiles2DataSet5 lankaTiles2DataSet5;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private LankaTiles2DataSet5TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource lankaTiles2DataSet5BindingSource;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private LankaTiles2DataSet5TableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private LankaTiles2DataSet5TableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource1;
    }
}