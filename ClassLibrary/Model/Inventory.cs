using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    [Table("Inventory")]
    public class Inventory
    {
        DataAccess db = new DataAccess();
        public int ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int BuyPrice { get; set; }
        public int Amount { get; set; }
        public string AmountType { get; set; }
        public int SupplierID { get; set; }

        public List<Inventory> addInventory(string Type, string Name, int BuyPrice, int Amount, string AmountType, int SupplierID)
        {
            this.Type = Type;this.Name = Name;this.BuyPrice = BuyPrice;this.Amount = Amount; this.AmountType = AmountType; this.SupplierID = SupplierID;
            db.Inventories.Add(this);
            db.SaveChanges();
            return viewInventory();

        }

       

        public List<Inventory> removeInventory(int ID)
        {
            var inventoryItem = db.Inventories.FirstOrDefault(x => x.ID == ID);
            db.Inventories.Remove(inventoryItem);
            db.SaveChanges();
            return viewInventory();
        }
        public List<Inventory> updateInventory(int ID ,string Type, string Name, int BuyPrice, int Amount, string AmountType, int SupplierID)
        {
            var inventoryItem = db.Inventories.FirstOrDefault(x => x.ID == ID);
            inventoryItem.Type = Type; inventoryItem.Name = Name; inventoryItem.Name = Name; inventoryItem.BuyPrice = BuyPrice; inventoryItem.Amount = Amount; inventoryItem.AmountType = AmountType; 
            db.Inventories.Update(inventoryItem);
            db.SaveChanges();
            return viewInventory();
        }

        public List<Inventory> Search(int ID)
        {
            List<Inventory> inventoryItem = db.Inventories.Where(x => x.ID == ID).ToList();
            return inventoryItem;
        }
        public List<Inventory> Search(string Name)
        {
            List<Inventory> inventoryItem = db.Inventories.Where(x => x.Name == Name).ToList();
            return inventoryItem;
        }

        public List<Inventory> viewInventory()
        {
            return db.Inventories.ToList();
        }

    }
}
