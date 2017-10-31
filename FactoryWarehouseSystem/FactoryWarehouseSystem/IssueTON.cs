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
    public partial class IssueTON : Form
    {
        DataTable dt;
        public IssueTON()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbItemCode.Text = "";
            cmbItemName.Text = "";
            txtQty.Clear();
            txtUnitPrice.Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (string.IsNullOrEmpty(cmbItemCode.Text) || string.IsNullOrEmpty(cmbItemName.Text)||string.IsNullOrEmpty(txtQty.Text)||string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                MessageBox.Show("Empty Fields!");
            }
            else if (!txtQty.Text.Any(char.IsDigit)||!txtUnitPrice.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Quantity and Price is not valid!");
            }
            else
            {
                string queryTemp = " insert into tonTemp (itemCode, itemName, qty, unitPrice)values ( '" + cmbItemCode.Text + "','" + cmbItemName.Text + "'," + txtQty.Text + "," + txtUnitPrice.Text + ")";
               // MessageBox.Show(queryTemp);
                db.inserUpdateDelete(queryTemp);
                dt = new DataTable();
                dt = db.select("select * from tonTemp");
                dataGridView1.DataSource = dt;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedTONId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);            
            DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Database db = new Database();
                db.inserUpdateDelete("delete from tonTemp where no = " + selectedTONId + "");
                dt = new DataTable();
                dt = db.select("select * from tonTemp");
                dataGridView1.DataSource = dt;
            }            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueTON_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString();
        }
    }
}
