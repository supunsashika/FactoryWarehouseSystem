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
        Database db;
        Invoice invoice;
        public Invoice_Management()
        {
            InitializeComponent();
        }

        public void Invoice_Management_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            AddInvoice invoice = new AddInvoice();
             invoice.ShowDialog();           
        }       

        private void btnRemoveInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int selectedInvId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    invoice = new Invoice();
                    invoice.remove(selectedInvId);
                    MessageBox.Show("Deleted Successfully!");
                    dt = new DataTable();
                    dt = invoice.getInvoice();
                    dataGridView2.DataSource = null;
                    dataGridView1.DataSource = dt;
                }
            }             
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            invoice = new Invoice();
            dt = new DataTable();
            db = new Database();
            db.inserUpdateDelete("delete from invTemp");
            dt = invoice.getInvoice();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int selectedInvId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                invoice = new Invoice();
                dt = new DataTable();
                dt = invoice.getInvoice(selectedInvId);
                dataGridView2.DataSource = dt;

                dataGridView2.Columns[0].Width = 200;
                dataGridView2.Columns[1].Width = 150;
                dataGridView2.Columns[2].Width = 50;

                txtID.Text = selectedInvId.ToString();
                txtCusName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();                
                txtDate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }            
        }
       
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                txtItemName.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtQty.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtStatus.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();               
            }            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            invoice = new Invoice();
            dt = new DataTable();
            dt = invoice.search(txtSearch.Text);
            dataGridView1.DataSource = dt;
        }     

        public void LoadDataGrid()
        {
            invoice = new Invoice();
            dt = new DataTable();
            db = new Database();
            db.inserUpdateDelete("delete from invTemp");
            dt = invoice.getInvoice();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
        }

        private void Invoice_Management_Activated(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
    }
}
