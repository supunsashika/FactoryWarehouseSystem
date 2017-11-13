using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FactoryWarehouseSystem
{
    public partial class Add_New_Supplier : Form
    {
        public Add_New_Supplier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocation.Text)||string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Empty Fields!!");
            }
            else
            {
                Supplier supplier = new Supplier();
                supplier.Id = txtSupID.Text;
                supplier.Location = txtLocation.Text;
                supplier.Name = txtName.Text;
                supplier.addSupplier();
                MessageBox.Show("Supplier Added!");
                this.Close();
            }
        }

        private void Add_New_Supplier_Load(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            string id = supplier.getMaxID();
            if (string.IsNullOrEmpty(id))
            {
                txtSupID.Text = "1";
            }
            else
            {
                txtSupID.Text = (Convert.ToInt32(id) + 1).ToString();
            }

        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
