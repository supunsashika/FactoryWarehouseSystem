using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWarehouseSystem
{
    class TransferOutNote
    {
        private int TONID;
        private int date;
        private string itemType;

        private int qty;
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        private string fromLocation;
        public string FromLocation
        {
            get { return fromLocation; }
            set { fromLocation = value; }
        }

        private string destination;
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }


        public void viewTON() { }
        public void addTON()
        {
            Database db = new Database();
            string queryTON = "insert into TON (date, fromLocation, destination) values ('"+DateTime.Now.ToString()+"', '"+fromLocation+"','"+destination+"')";
            db.inserUpdateDelete(queryTON);
            addTONDetail();
        }

        public void addTONDetail()
        {
            Database db = new Database();
            string query = "insert into TONDetails select TONID, itemID, qty from tonTemp";
            db.inserUpdateDelete(query);
        }
        public string getMaxId()
        {
            Database db = new Database();
            string id= db.getValue("select max(TONID) from TON");
            return id;
        }
        public void verifyTON() { }
        public void removeTON() { }
        public void searchTON() { }




    }
}
