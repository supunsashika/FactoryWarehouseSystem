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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIssueTON = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnAddGRN = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIssueTON
            // 
            this.btnIssueTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueTON.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnIssueTON.Location = new System.Drawing.Point(586, 263);
            this.btnIssueTON.Name = "btnIssueTON";
            this.btnIssueTON.Size = new System.Drawing.Size(132, 70);
            this.btnIssueTON.TabIndex = 0;
            this.btnIssueTON.Text = "Issue Transfer Out Note";
            this.btnIssueTON.UseVisualStyleBackColor = true;
            this.btnIssueTON.Click += new System.EventHandler(this.btnIssueTON_Click);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddNewItem.Location = new System.Drawing.Point(172, 263);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(132, 70);
            this.btnAddNewItem.TabIndex = 1;
            this.btnAddNewItem.Text = "Items";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoice.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddInvoice.Location = new System.Drawing.Point(310, 263);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(132, 70);
            this.btnAddInvoice.TabIndex = 2;
            this.btnAddInvoice.Text = "Invoices";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnAddGRN
            // 
            this.btnAddGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGRN.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddGRN.Location = new System.Drawing.Point(448, 263);
            this.btnAddGRN.Name = "btnAddGRN";
            this.btnAddGRN.Size = new System.Drawing.Size(132, 70);
            this.btnAddGRN.TabIndex = 3;
            this.btnAddGRN.Text = "Issue Goods to Warehouse";
            this.btnAddGRN.UseVisualStyleBackColor = true;
            this.btnAddGRN.Click += new System.EventHandler(this.btnAddGRN_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSuppliers.Location = new System.Drawing.Point(34, 263);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(132, 70);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(164, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Factory Management Console";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnAddGRN);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.btnIssueTON);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Factory Management Console";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssueTON;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnAddGRN;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

