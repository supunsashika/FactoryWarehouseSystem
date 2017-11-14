namespace FactoryWarehouseSystem
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
            this.btnIssueTON = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnAddGRN = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIssueTON
            // 
            this.btnIssueTON.Location = new System.Drawing.Point(12, 12);
            this.btnIssueTON.Name = "btnIssueTON";
            this.btnIssueTON.Size = new System.Drawing.Size(132, 70);
            this.btnIssueTON.TabIndex = 0;
            this.btnIssueTON.Text = "Issue Transfer Out Note";
            this.btnIssueTON.UseVisualStyleBackColor = true;
            this.btnIssueTON.Click += new System.EventHandler(this.btnIssueTON_Click);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(150, 12);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(132, 70);
            this.btnAddNewItem.TabIndex = 1;
            this.btnAddNewItem.Text = "Add / Remove Items";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(288, 12);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(132, 70);
            this.btnAddInvoice.TabIndex = 2;
            this.btnAddInvoice.Text = "Add Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnAddGRN
            // 
            this.btnAddGRN.Location = new System.Drawing.Point(426, 12);
            this.btnAddGRN.Name = "btnAddGRN";
            this.btnAddGRN.Size = new System.Drawing.Size(132, 70);
            this.btnAddGRN.TabIndex = 3;
            this.btnAddGRN.Text = "Issue Goods to Warehouse";
            this.btnAddGRN.UseVisualStyleBackColor = true;
            this.btnAddGRN.Click += new System.EventHandler(this.btnAddGRN_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(12, 88);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(132, 70);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 163);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnAddGRN);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.btnIssueTON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIssueTON;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnAddGRN;
        private System.Windows.Forms.Button btnSuppliers;
    }
}

