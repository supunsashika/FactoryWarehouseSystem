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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIssueTON_Click(object sender, EventArgs e)
        {
            IssueTON frmIssueTON = new IssueTON();
            frmIssueTON.ShowDialog();
            
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem addNewItem = new AddNewItem();
            addNewItem.ShowDialog();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            Invoice_Management invoice_Management = new Invoice_Management();
            invoice_Management.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddGRN_Click(object sender, EventArgs e)
        {
            Purchased_Goods purchased_Goods = new Purchased_Goods();
            purchased_Goods.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.ShowDialog();
           
        }
    }
}
