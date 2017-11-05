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
    public partial class AddInvoice : Form
    {
        DataTable dt;
        public AddInvoice()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQty.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Quantuty cannot be empty!");
            }
            else if (!txtQty.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Quantity has to be Numeric!");
            }
            else
            {
                Database db = new Database();
                dt = new DataTable();
                dt = db.select("select * from invTemp");
                int mark = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row.Field<int>(1) == Convert.ToInt32(cmbItemID.Text))
                    {
                        mark = 1;
                        break;
                    }
                }

                if (mark == 1)
                {
                    string updateQuery = "update invTemp set qty = qty+" + txtQty.Text + " where itemID = " + cmbItemID.Text + "";
                    //MessageBox.Show(updateQuery);
                    db.inserUpdateDelete(updateQuery);
                }
                else
                {
                    string query = "insert into invTemp values (" + txtInvID.Text + "," + cmbItemID.Text + "," + txtQty.Text + ")";
                    db.inserUpdateDelete(query);
                }
                dt = db.select("select * from invTemp");
                dataGridView1.DataSource = dt;
            }
        }

        private void AddInvoice_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString();
            Invoice invoice = new Invoice();
            string id = invoice.getMaxID();            
            if (string.IsNullOrEmpty(id))
            {
                txtInvID.Text = "1";
            }
            else
            {
                txtInvID.Text = (Convert.ToInt32(id)+1).ToString();
            }

            //Fill combo
            Item item = new Item();
            dt = new DataTable();
            dt = item.getItemDetails();
            cmbItemID.DataSource = dt;
            cmbItemID.ValueMember = "itemID";
            cmbItemCode.DataSource = dt;
            cmbItemCode.ValueMember = "itemCode";

            //delete temp
            Database db = new Database();
            db.inserUpdateDelete("delete from invTemp");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedTONId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Database db = new Database();
                db.inserUpdateDelete("delete from invTemp where itemID = " + selectedTONId + "");
                dt = new DataTable();
                dt = db.select("select * from invTemp");
                dataGridView1.DataSource = dt;
            }
        }

        private void btnIssueInv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCusName.Text))
            {
                MessageBox.Show("Please Enter Customer Name!");
            }
            else
            {
                Invoice invoice = new Invoice();
                invoice.CusName = txtCusName.Text;                
                invoice.addInvoice();
                this.Close();
            }
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
