using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryWarehouseSystem
{
    class Invoice
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private string cusName;
        public string CusName
        {
            get { return cusName; }
            set { cusName = value; }
        }


        public DataTable getInvoice()
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from invoice");
            return dt;
        }
        public DataTable getInvoice(int id)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from invoiceDetails where invID = " + id + "");
            return dt;
        }

        public string getMaxID()
        {
            Database db = new Database();
            string val;
            val = db.getValue("select max(invID) from invoice");
            return val;
        }
        public void addInvoice()
        {
            Database db = new Database();
            string query = "insert into invoice values ("+id+",'" + DateTime.Now.ToString() + "','" + cusName + "') ";
            db.inserUpdateDelete(query);
            addInvDetails();
            MessageBox.Show("Invoice Added!");
        }
        public void addInvDetails()
        {
            Database db = new Database();
            db.inserUpdateDelete("insert into invoiceDetails select invID, itemID, qty from invTemp");
        }
        public void remove(int id)
        {
            Database db = new Database();
            db.inserUpdateDelete("delete from invoice where invID = "+id+"");
            db.inserUpdateDelete("delete from invoiceDetails where invID = " + id + "");
        }
    }
}
