using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FactoryWarehouseSystem
{
    class Supplier
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string location;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string getMaxID()
        {
            Database db = new Database();
            string id = db.getValue("select max(supID) from Supplier");
            return id;
        }
        public void addSupplier()
        {
            Database db = new Database();
            db.inserUpdateDelete("insert into Supplier values ("+id+",'"+name+"','"+location+"') ");
        }
        public DataTable getSupplier()
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from Supplier");
            return dt;
        }
        public DataTable getSupplier(string supName)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select supID from Supplier where supName = '" + supName + "'");
            return dt;
        }
        public void removeSupplier(int id)
        {
            Database db = new Database();
            db.inserUpdateDelete("delete from Supplier where supID = " + id + "");
        }
    }

}
