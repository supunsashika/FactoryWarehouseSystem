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
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {         
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(txtItemCode.Text) || string.IsNullOrEmpty(txtUnitPrice.Text)||string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Empty Fields!");
            }
            else if (!txtQty.Text.Any(char.IsDigit)||!txtUnitPrice.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Quantity and Price cannot contain letters! Please check.");
            }
            else
            {
                Item item = new Item();              
                item.ItemCode = txtItemCode.Text;
                item.ItemName = txtItemName.Text;
                item.ItemQty = Convert.ToInt32(txtQty.Text);
                item.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);

                dt = item.getItemDetails();
                dataGridView1.DataSource = dt;
                int mark = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["itemCode"].ToString() == txtItemCode.Text)
                    {                        
                        MessageBox.Show("Item already Exists!");
                        mark = 1;
                        break;
                    }
                    else
                    {
                        mark = 0;    
                    }
                }
                if (mark == 0)
                {
                    item.addItem();
                    txtItemCode.Clear();
                    txtItemName.Clear();
                    txtUnitPrice.Clear();
                    txtQty.Clear();
                }
                dt = item.getItemDetails();
                dataGridView1.DataSource = dt;
            }
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {            
            DataTable dt = new DataTable();
            Item item = new Item();
            dt = item.getItemDetails();
            dataGridView1.DataSource = dt;   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            int selected =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);              
            DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                item.deleteItem(selected);
                DataTable dt = new DataTable();
                dt = item.getItemDetails();
                dataGridView1.DataSource = dt;
            }            
        }
    }
}
