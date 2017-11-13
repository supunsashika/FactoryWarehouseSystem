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
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            dt = supplier.getSupplier();
            dataGridView1.DataSource = dt;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Add_New_Supplier supplier = new Add_New_Supplier();
            supplier.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            dt = supplier.getSupplier();
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedSupId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Supplier supplier = new Supplier();
            supplier.removeSupplier(selectedSupId);
            MessageBox.Show("Supplier Deleted!");
        }
    }
}
