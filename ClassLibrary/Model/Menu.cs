using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.Model
{   
    [Table("Menu")]
    public class Menu
    {
        DataAccess db = new DataAccess();
        public int ID { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        public float SellPrice { get; set; }
        public string Nutritions { get; set; }
        public string Allergic { get; set; }
        public int IsAvailable { get; set; }
        public byte[] Image { get; set; }
        public string Category{ get; set; }

        public List<Menu> addMenu(string Name, float Cost, float SellPrice, string Nutritions, string Allergic, int IsAvailable, byte[] Image, string Category)
        {
            this.Name = Name;this.Cost = Cost;this.SellPrice = SellPrice;this.Nutritions = Nutritions;this.Allergic = Allergic;this.IsAvailable = IsAvailable;this.Image = Image;this.Category = Category;
            db.MenuItems.Add(this);
            db.SaveChanges();
            return viewMenu();
        }
        public List<Menu> removeMenu(int ID)
        {
            var menuitem = db.MenuItems.FirstOrDefault(x => x.ID == ID);
            db.MenuItems.Remove(menuitem);
            db.SaveChanges();
            return viewMenu();
        }
        public List<Menu> Search(int ID)
        {
            List<Menu> tableItem = db.MenuItems.Where(x => x.ID == ID).ToList();
            return tableItem;
        }
        public List<Menu> Search(string Name)
        {
            List<Menu> tableItem = db.MenuItems.Where(x => x.Name == Name).ToList();
            return tableItem;
        }
        public List<Menu> updateMenu(int ID, string Name, float Cost, float SellPrice, string Nutritions, string Allergic, int IsAvailable, byte[] Image, string Category)
        {
            var menuitem = db.MenuItems.FirstOrDefault(x => x.ID == ID);
            menuitem.Name = Name; menuitem.Cost = Cost; menuitem.SellPrice = SellPrice; menuitem.Nutritions = Nutritions; menuitem.Allergic = Allergic; menuitem.IsAvailable = IsAvailable; menuitem.Image = Image; menuitem.Category = Category;
            db.MenuItems.Update(menuitem);
            db.SaveChanges();
            return viewMenu();
        }
        
        public List<Menu> viewMenu()
        {
            return db.MenuItems.ToList();
        }
       
        
    }
}
