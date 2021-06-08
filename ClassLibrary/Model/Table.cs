using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.Model
{
    [Table("Table")]
    public class Table
    {
        DataAccess db = new DataAccess();
        public int ID { get; set; }
        public int LocationID { get; set; }
        public int IsAvailable { get; set; }
        public int IsReserved { get; set; }
        public int ResponsibleEmployee { get; set; }

        public List<Table> addTable( int LocationID, int IsAvailable, int IsReserved, int ResponsibleEmployee)
        {
            this.LocationID = LocationID; this.IsAvailable = IsAvailable; this.IsReserved = IsReserved; this.ResponsibleEmployee = ResponsibleEmployee;
            db.Tables.Add(this);
            db.SaveChanges();
            return viewTable();
        }

        public List<Table> removeTable(int ID)
        {
            var tableitem = db.Tables.FirstOrDefault(x => x.ID == ID);
            db.Tables.Remove(tableitem);
            db.SaveChanges();
            return viewTable();
        }
        public List<Table> Search(int ID)
        {
            List<Table> tableItem = db.Tables.Where(x => x.ID == ID).ToList();
            return tableItem;
        }
        public List<Table> Search(string Id)
        {
            int ID = int.Parse(Id);
            List<Table> tableItem = db.Tables.Where(x => x.ID == ID).ToList();
            return tableItem;
        }
        public List<Table> updateTable(int ID, int LocationID, int IsAvailable, int IsReserved, int ResponsibleEmployee)
        {
            var tableitem = db.Tables.FirstOrDefault(x => x.ID == ID);
            tableitem.LocationID = LocationID; tableitem.IsAvailable = IsAvailable; tableitem.IsReserved = IsReserved; tableitem.ResponsibleEmployee = ResponsibleEmployee;
            db.Tables.Update(tableitem);
            db.SaveChanges();
            return viewTable();

        }
        public List<Table> viewTable()
        {
            return db.Tables.ToList();
        }
        public List<Table> modifyAvailibility(int ID, int IsAvailable)
        {
            var tableitem = db.Tables.FirstOrDefault(x => x.ID == ID);
            tableitem.IsAvailable = IsAvailable;
            db.Tables.Update(tableitem);
            db.SaveChanges();
            return viewTable();
        }
       
    }
}
