using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    [Table("Supplier")]
    public class Supplier
    {
        DataAccess db = new DataAccess();
        public int ID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Info { get; set; }

        public List<Supplier> addSupplier(string Name, string Contact, string Info)
        {
            this.Name = Name; this.Contact = Contact; this.Info = Info;
            db.Suppliers.Add(this);
            db.SaveChanges();
            return viewSupplier();
        }
        public List<Supplier> removeSupplier(int ID)
        {
            var supplyitem = db.Suppliers.FirstOrDefault(x => x.ID == ID);
            db.Suppliers.Remove(supplyitem);
            db.SaveChanges();
            return viewSupplier();
        }
        public List<Supplier> updateSupplier(int ID,string Name, string Contact, string Info)
        { 
            var supplyitem = db.Suppliers.FirstOrDefault(x => x.ID == ID);
            supplyitem.Name = Name; supplyitem.Contact = Contact; supplyitem.Info = Info;
            db.Suppliers.Update(supplyitem);
            db.SaveChanges();
            return viewSupplier();
            
        }
        public List<Supplier> viewSupplier()
        {
            return db.Suppliers.ToList();
        }
        public List<Supplier> Search(int ID)
        {
            List<Supplier> supplyItem = db.Suppliers.Where(x => x.ID == ID).ToList();
            return supplyItem;
        }
        public List<Supplier> Search(string Name)
        {
            List<Supplier> supplyItem = db.Suppliers.Where(x => x.Name == Name).ToList();
            return supplyItem;
        }
    }
}
