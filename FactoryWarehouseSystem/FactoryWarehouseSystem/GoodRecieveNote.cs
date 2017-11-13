using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FactoryWarehouseSystem
{
    class GoodRecieveNote
    {
        public DataTable dt;
        public string id { get; set; }
        public string date { get; set; }
        public string supID { get; set; }

        public string getMaxID()
        {
            Database db = new Database();
            string id = db.getValue("select max(GRNID) from GRN");
            return id;
        }
        public void addGRN()
        {
            Database db = new Database();
            db.inserUpdateDelete("insert into GRN values (" + id + ",'" + date + "','" + supID + "',0)");
            addGRNDetails();
        }
        public void addGRNDetails()
        {
            Database db = new Database();
            db.inserUpdateDelete("insert into GRNDetails select GRNID, itemID, qty, IsDelivered from GRNTemp ");
        }
        public void deleteTemp()
        {
            Database db = new Database();
            db.inserUpdateDelete("delete from GRNTemp");
        }
    }
}
