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
    public partial class Suppliers : Form
    {
        public DataTable dt;
        Supplier supplier;
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            supplier = new Supplier();
            dt = supplier.getSupplier();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width =200;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            supplier = new Supplier();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            supplier = new Supplier();
            dt = supplier.getSupplier();
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int selectedSupId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                supplier = new Supplier();
                supplier.removeSupplier(selectedSupId);
                MessageBox.Show("Supplier Deleted!");
                Suppliers_Load(sender, e);
            }            
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocation.Text) || string.IsNullOrEmpty(txtName.Text))
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
                Suppliers_Load(sender, e);
                groupBox1.Enabled = false;
                ClearFields();                
            }
        }
        private void ClearFields()
        {
            txtLocation.Clear();
            txtSupID.Clear();
            txtName.Clear();
        }
    }
}
