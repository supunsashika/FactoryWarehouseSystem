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
        DataTable dt,dt2,dt3;
        GoodRecieveNote grn;
        Database db;
        Item item;
        Supplier supplier;
        public Purchased_Goods()
        {
            InitializeComponent();
        }

        private void Purchased_Goods_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString();
            grn = new GoodRecieveNote();
            grn.deleteTemp();
            string id =  grn.getMaxID();

            if (string.IsNullOrEmpty(id))            
                txtGRNID.Text = "1";            
            else            
                txtGRNID.Text = (Convert.ToInt16(id) + 1).ToString();
            

            item = new Item();
            dt = new DataTable();
            dt = item.getItemDetails();
            
            cmbItemID.ValueMember = "ID";
            cmbItemID.DisplayMember = "ID";
            cmbItemID.DataSource = dt;

            supplier = new Supplier();
            dt2 = new DataTable();
            dt2 = supplier.getSupplier();

            cmbSupName.ValueMember = "ID";
            cmbSupName.DisplayMember = "Supplier";
            cmbSupName.DataSource = dt2;

            dt3 = new DataTable();
            db = new Database();
            dt3 = db.select("select location from warehouses");

            cmbDestination.ValueMember = "location";
            cmbDestination.DisplayMember = "location";
            cmbDestination.DataSource = dt3;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Quantity cannot be empty!");
            }
            else if (!txtQty.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Quantity has to be Numeric!");
            }
            else
            {
                db = new Database();
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
                dt = db.select("select itemID as [Item ID], qty as Quantity, isdelivered as [Delivary Status] from GRNTemp");
                dataGridView1.DataSource = dt;
            }
        }

        private void cmbSupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplier = new Supplier();
            dt = supplier.getSupplier(cmbSupName.Text);             
            txtSupID.Text = dt.Rows[0][0].ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int selectedItemId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    db = new Database();
                    db.inserUpdateDelete("delete from GRNTemp where itemID = " + selectedItemId + "");
                    dt = new DataTable();
                    dt = db.select("select * from GRNTemp");
                    dataGridView1.DataSource = dt;
                }
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
                grn = new GoodRecieveNote();
                grn.id = txtGRNID.Text;
                grn.date = txtDate.Text;
                grn.supID = txtSupID.Text;
                grn.addGRN();
                MessageBox.Show("GRN Added Successfully!");
                this.Close();
            }
        }

        private void cmbItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = new Item();
            dt = new DataTable();
            dt = item.getItemDetails(cmbItemID.SelectedValue.ToString());
            txtItemCode.Text = dt.Rows[0][1].ToString();
            
        }
    }
}
