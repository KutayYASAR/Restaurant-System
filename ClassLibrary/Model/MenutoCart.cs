using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.Model
{
    [Table("MenutoCart")]
    public class MenutoCart
    {
        DataAccess db = new DataAccess();
        public int ID { get; set; }
        public int ProductID{ get; set; }
        public int TableID{ get; set; }

        public void addCart(int ProductID,int TableID)
        {
            this.TableID = TableID;this.ProductID = ProductID;
            db.Cart.Add(this);
             db.SaveChanges();
            Console.WriteLine("asdasd");
        }
    }
}
