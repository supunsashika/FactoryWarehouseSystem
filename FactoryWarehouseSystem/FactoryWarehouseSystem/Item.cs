using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWarehouseSystem
{
    class Item
    {     
        private int itemID;
        public int ItemID        {
            get { return itemID; }
            set { itemID = value; }
        }

        private string itemCode;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private int itemQty;
        public int ItemQty
        {
            get { return itemQty; }
            set { itemQty = value; }
        }

        private double unitPrice;
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        private string RFID;
        public string rfid
        {
            get { return RFID; }
            set { RFID = value; }
        }

        public DataTable getItemDetails()
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from item");
            return dt;
        }

        public void addItem()
        {
            Database db = new Database();
            string id = db.getValue("select max(itemID) from item");
            if (string.IsNullOrEmpty(id))
            {
                id = "1";
            }
            else
            {
                id = (Convert.ToInt32(id) + 1).ToString();
            }
            string query = "insert into item values (" + id + ",'" + itemCode + "',"
                +"'" + itemName + "'," + unitPrice + ", " + itemQty + ",'" + RFID + "')";
            db.inserUpdateDelete(query);
        }

        public void deleteItem(int id)
        {
            Database db = new Database();
            string query = "delete from item where itemID = "+id+"";
            db.inserUpdateDelete(query);
        }

        public string getQty(string id)
        {
            string qty;
            Database db = new Database();
            qty = db.getValue("select qty from item where itemID = " + id + "");
            return qty;
        }
        public void adjustMinimumStockBalance() { }
        public void viewStock() { }
        public void updateStock() { }
    }
}
