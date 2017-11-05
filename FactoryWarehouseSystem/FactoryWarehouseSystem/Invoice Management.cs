using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryWarehouseSystem
{
    public partial class Invoice_Management : Form
    {
        DataTable dt;
        public Invoice_Management()
        {
            InitializeComponent();
        }

        private void Invoice_Management_Load(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            DataTable dt = new DataTable();
            Database db = new Database();
            db.inserUpdateDelete("delete from invTemp");
            dt = invoice.getInvoice();
            dataGridView1.DataSource = dt;
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            AddInvoice invoice = new AddInvoice();
            invoice.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int selectedInvId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Invoice invoice = new Invoice();
            dt = new DataTable();
            dt = invoice.getInvoice(selectedInvId);
            dataGridView2.DataSource = dt;
        }

        private void btnRemoveInvoice_Click(object sender, EventArgs e)
        {
            int selectedInvId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Invoice invoice = new Invoice();
                invoice.remove(selectedInvId);
                MessageBox.Show("Deleted Successfully!");
                dt = new DataTable();
                dt = invoice.getInvoice();
                dataGridView1.DataSource = dt;
            }            
        }
    }
}
