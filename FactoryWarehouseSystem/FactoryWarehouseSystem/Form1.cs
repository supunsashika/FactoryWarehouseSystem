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
    }
}
