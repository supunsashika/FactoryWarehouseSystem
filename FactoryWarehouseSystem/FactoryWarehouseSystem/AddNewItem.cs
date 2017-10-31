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
            Database db = new Database();
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(txtItemName.Text)||string.IsNullOrEmpty(txtItemCode.Text))
            {
                MessageBox.Show("Item name & code cannot be empty!");
            }
            else
            {
                dt = db.select("select * from item");
                dataGridView1.DataSource = dt;

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["itemCode"].ToString() == txtItemCode.Text)
                    {                        
                        MessageBox.Show("Item already Exists!");
                        break;
                    }
                    else
                    {
                        db.inserUpdateDelete("insert into item (itemCode, itemName) values ('" + txtItemCode.Text + "','" + txtItemName.Text + "') ");
                        break;
                    }
                }     
                txtItemCode.Clear();
                txtItemName.Clear();
            }
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from item");
            dataGridView1.DataSource = dt;   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selected =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Database db = new Database();
            string q = "delete from item where itemID = " + selected + "";
            DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                db.inserUpdateDelete(q);
                DataTable dt = new DataTable();
                dt = db.select("select * from item");
                dataGridView1.DataSource = dt;
            }            
        }
    }
}
