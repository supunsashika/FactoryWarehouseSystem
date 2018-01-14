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
        Database db;
        DataTable dt;
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
            db = new Database();
            dt = new DataTable();
            dt = db.select("select invId as ID, date as Date, cusName as Customer from invoice");
            return dt;
        }
        public DataTable getInvoice(int id)
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("SELECT item.itemName AS Item, invoiceDetails.qty AS Quantity, " +
                "invoiceDetails.IsIssued AS [Issue Status] FROM item INNER JOIN invoiceDetails " +
                "ON item.itemID = invoiceDetails.itemID WHERE(invoiceDetails.invID = " + id + ")");
            return dt;
        }

        public string getMaxID()
        {
            db = new Database();
            string val;
            val = db.getValue("select max(invID) from invoice");
            return val;
        }
        public void addInvoice()
        {
            db = new Database();
            string query = "insert into invoice values (" + id + ",'" + DateTime.Now.ToString() + "','" + cusName + "',0) ";
            db.inserUpdateDelete(query);
            addInvDetails();
            MessageBox.Show("Invoice Added!");
        }
        public void addInvDetails()
        {
            db = new Database();
            db.inserUpdateDelete("insert into invoiceDetails select invID, itemID, qty,IsIssued from invTemp");
          
        }
        public void remove(int id)
        {
            db = new Database();            
            db.inserUpdateDelete("delete from invoiceDetails where invID = " + id + "");
            db.inserUpdateDelete("delete from invoice where invID = " + id + "");
        }

        public DataTable search(string searchString)
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("select invId as ID, date as Date, cusName as Customer from invoice where cusName like '%" + searchString + "%' ");
            return dt;
        } 
    }
}
