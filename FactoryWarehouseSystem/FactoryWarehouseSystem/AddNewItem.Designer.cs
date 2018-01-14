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
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(114, 6);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(295, 20);
            this.txtItemCode.TabIndex = 2;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(114, 32);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(295, 20);
            this.txtItemName.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(332, 147);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(398, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(241, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Selected Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(114, 58);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(295, 20);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(114, 84);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(295, 20);
            this.txtQty.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "RFID";
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(114, 110);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(227, 20);
            this.txtRFID.TabIndex = 12;
            this.txtRFID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRFID_MouseClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(347, 108);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Get RFID";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 385);
            this.Controls.Add(this.btnRefresh);
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
        private System.Windows.Forms.Button btnRefresh;
    }
}