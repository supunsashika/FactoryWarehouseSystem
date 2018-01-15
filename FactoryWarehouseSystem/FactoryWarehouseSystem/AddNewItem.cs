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
    public partial class AddNewItem : Form
    {
        DataTable dt;
        Item item;
        RFID rfid;
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {         
            dt = new DataTable();
            ControlElements(true);
            ClearFields();
            btnAddItem.Enabled = false;
            btnCancal.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnGetRFID.Enabled = true;
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {            
            dt = new DataTable();
            item = new Item();

            //Disable elements
            ControlElements(false);

            dt = item.getItemDetails();
            dataGridView1.DataSource = dt;
            SetDataGridDesign();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            item = new Item();
            if (dataGridView1.CurrentCell!=null)
            {
                int selected = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    item.deleteItem(selected);
                    MessageBox.Show("Item Deleted Successfully!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dt = new DataTable();
                    dt = item.getItemDetails();
                    dataGridView1.DataSource = dt;
                    SetDataGridDesign();
                    ClearFields();
                }
            }                  
        }  
             
        private void ControlElements(bool val)
        {
            txtItemCode.Enabled = val;
            txtItemName.Enabled = val;
            txtQty.Enabled = val;
            txtRFID.Enabled = val;
            txtUnitPrice.Enabled = val;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell!=null)
            {
                int selected = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtItemCode.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtItemName.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtUnitPrice.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtQty.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtRFID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            item = new Item();
            dt = new DataTable();
            dt = item.search(txtSearch.Text);
            dataGridView1.DataSource = dt;
            SetDataGridDesign();
        }
        private void SetDataGridDesign()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(txtItemCode.Text) || string.IsNullOrEmpty(txtUnitPrice.Text) || string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Empty Fields!");
            }
            else if (!txtQty.Text.Any(char.IsDigit) || !txtUnitPrice.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Quantity and Price cannot contain letters! Please check fields!");
            }
            else
            {
                item = new Item();
                item.ItemCode = txtItemCode.Text;
                item.ItemName = txtItemName.Text;
                item.ItemQty = Convert.ToInt32(txtQty.Text);
                item.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
                item.rfid = txtRFID.Text;

                dt = item.getItemDetails();
                dataGridView1.DataSource = dt;
                SetDataGridDesign();

                int mark = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Code"].ToString() == txtItemCode.Text)
                    {
                        MessageBox.Show("Item already Exists!");
                        mark = 1;
                        break;
                    }
                    else                    
                        mark = 0;                    
                }
                if (mark == 0)
                {
                    item.addItem();
                    MessageBox.Show("Item Added Successfully!");
                    btnGetRFID.Enabled = false;
                    ControlElements(false);
                    ClearFields();
                }

                dt = item.getItemDetails();
                dataGridView1.DataSource = dt;
                SetDataGridDesign();
            }
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            btnAddItem.Enabled = true;
            btnCancal.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnGetRFID.Enabled = false;
            ControlElements(false);
        }
        private void ClearFields()
        {
            txtItemCode.Clear();
            txtItemName.Clear();
            txtQty.Clear();
            txtRFID.Clear();
            txtUnitPrice.Clear();
        }

        private void btnGetRFID_Click(object sender, EventArgs e)
        {
            rfid = new RFID();
            txtRFID.Text = rfid.getRFID();
        }
    }
}
