namespace FactoryWarehouseSystem
{
    partial class Invoice_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice_Management));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnRemoveInvoice = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(342, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(571, 390);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(155, 37);
            this.btnAddInvoice.TabIndex = 1;
            this.btnAddInvoice.Text = "Add New Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(375, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(496, 239);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnRemoveInvoice
            // 
            this.btnRemoveInvoice.Location = new System.Drawing.Point(732, 390);
            this.btnRemoveInvoice.Name = "btnRemoveInvoice";
            this.btnRemoveInvoice.Size = new System.Drawing.Size(139, 37);
            this.btnRemoveInvoice.TabIndex = 2;
            this.btnRemoveInvoice.Text = "Delete Invoice";
            this.btnRemoveInvoice.UseVisualStyleBackColor = true;
            this.btnRemoveInvoice.Click += new System.EventHandler(this.btnRemoveInvoice_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(159, 407);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search with Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Good Issue Status";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(403, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(92, 20);
            this.txtID.TabIndex = 13;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(475, 334);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(155, 20);
            this.txtItemName.TabIndex = 14;
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(716, 334);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(155, 20);
            this.txtQty.TabIndex = 15;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(475, 360);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(155, 20);
            this.txtStatus.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Customer Name";
            // 
            // txtCusName
            // 
            this.txtCusName.Enabled = false;
            this.txtCusName.Location = new System.Drawing.Point(671, 15);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(200, 20);
            this.txtCusName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(671, 45);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 20);
            this.txtDate.TabIndex = 20;
            // 
            // Invoice_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 443);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnRemoveInvoice);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Invoice_Management";
            this.Text = "Invoice Management";
            this.Activated += new System.EventHandler(this.Invoice_Management_Activated);
            this.Load += new System.EventHandler(this.Invoice_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRemoveInvoice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDate;
    }
}