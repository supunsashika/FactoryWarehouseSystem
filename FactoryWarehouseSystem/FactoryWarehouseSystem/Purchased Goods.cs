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
    public partial class Purchased_Goods : Form
    {
        public DataTable dt;
        public Purchased_Goods()
        {
            InitializeComponent();
        }

        private void Purchased_Goods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lankaTiles2DataSet4.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter1.Fill(this.lankaTiles2DataSet4.Supplier);
            // TODO: This line of code loads data into the 'lankaTiles2DataSet3.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter1.Fill(this.lankaTiles2DataSet3.item);
            // TODO: This line of code loads data into the 'lankaTiles2DataSet2.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.lankaTiles2DataSet2.item);
            // TODO: This line of code loads data into the 'lankaTiles2DataSet1.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.lankaTiles2DataSet1.Warehouses);
            // TODO: This line of code loads data into the 'lankaTiles2DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.lankaTiles2DataSet.Supplier);
            txtDate.Text = DateTime.Now.ToString();
            GoodRecieveNote grn = new GoodRecieveNote();
            grn.deleteTemp();
            string id =  grn.getMaxID();
            if (string.IsNullOrEmpty(id))
            {
                txtGRNID.Text = "1";
            }
            else
            {
                txtGRNID.Text = (Convert.ToInt16(id) + 1).ToString();
            }

            Item item = new Item();
            dt = new DataTable();
            dt = item.getItemDetails();
            cmbItemID.DataSource = dt;
            cmbItemID.ValueMember = "itemID";
            cmbItemCode.DataSource = dt;
            cmbItemCode.ValueMember = "itemCode";
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
                dt = db.select("select * from GRNTemp");
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
                    string updateQuery = "update GRNTemp set qty = qty+" + txtQty.Text + " where itemID = " + cmbItemID.Text + "";
                    //MessageBox.Show(updateQuery);
                    db.inserUpdateDelete(updateQuery);
                }
                else
                {
                    string query = "insert into GRNTemp values (" + txtGRNID.Text + "," + cmbItemID.Text + "," + txtQty.Text + ",0)";
                    db.inserUpdateDelete(query);
                }
                dt = db.select("select * from GRNTemp");
                dataGridView1.DataSource = dt;
            }
        }

        private void cmbSupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            dt = supplier.getSupplier(cmbSupName.Text);
            string id = dt.Rows[0][0].ToString();
            txtSupID.Text = id;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedItemId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Database db = new Database();
                db.inserUpdateDelete("delete from GRNTemp where itemID = " + selectedItemId + "");
                dt = new DataTable();
                dt = db.select("select * from GRNTemp");
                dataGridView1.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQty.Clear();
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueInv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDestination.Text)|| string.IsNullOrEmpty(cmbSupName.Text) || string.IsNullOrEmpty(txtSupID.Text))
            {
                MessageBox.Show("Please select supplier!");
            }
            else
            {
                GoodRecieveNote grn = new GoodRecieveNote();
                grn.id = txtGRNID.Text;
                grn.date = txtDate.Text;
                grn.supID = txtSupID.Text;
                grn.addGRN();
                MessageBox.Show("GRN Added Successfully!");
                this.Close();
            }
        }
    }
}
