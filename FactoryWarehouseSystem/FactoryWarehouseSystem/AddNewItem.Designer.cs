namespace FactoryWarehouseSystem
{
    partial class AddNewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewItem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancal = new System.Windows.Forms.Button();
            this.btnGetRFID = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(399, 12);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(295, 20);
            this.txtItemCode.TabIndex = 2;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(399, 38);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(295, 20);
            this.txtItemName.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(457, 330);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 43);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(282, 311);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(399, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Selected Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(399, 64);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(295, 20);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(399, 90);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(295, 20);
            this.txtQty.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "RFID";
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(399, 116);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(295, 20);
            this.txtRFID.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 352);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search with Item Code";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(538, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancal
            // 
            this.btnCancal.Enabled = false;
            this.btnCancal.Location = new System.Drawing.Point(619, 329);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(75, 43);
            this.btnCancal.TabIndex = 17;
            this.btnCancal.Text = "Cancal";
            this.btnCancal.UseVisualStyleBackColor = true;
            this.btnCancal.Click += new System.EventHandler(this.btnCancal_Click);
            // 
            // btnGetRFID
            // 
            this.btnGetRFID.Enabled = false;
            this.btnGetRFID.Location = new System.Drawing.Point(619, 153);
            this.btnGetRFID.Name = "btnGetRFID";
            this.btnGetRFID.Size = new System.Drawing.Size(75, 31);
            this.btnGetRFID.TabIndex = 18;
            this.btnGetRFID.Text = "Get RFID";
            this.btnGetRFID.UseVisualStyleBackColor = true;
            this.btnGetRFID.Click += new System.EventHandler(this.btnGetRFID_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(538, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 385);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetRFID);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewItem";
            this.Text = "Add / Remove Items";
            this.Load += new System.EventHandler(this.AddNewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancal;
        private System.Windows.Forms.Button btnGetRFID;
        private System.Windows.Forms.Button btnUpdate;
    }
}