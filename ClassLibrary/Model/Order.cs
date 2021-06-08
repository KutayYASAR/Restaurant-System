using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    [Table("Order")]
    public class Order
    {
        DataAccess db = new DataAccess();

        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }
        public int TableID  { get; set; }
        public string Type { get; set; }
        
        public int emptyOrder()
        {
            db.Order.Add(this);
            db.SaveChanges();
            var id = this.ID;
            return id;
        }
        public void addOrder(int EmployeeID ,double
            Total,string Status,int TableID ,string Type)
        {
            this.EmployeeID = EmployeeID; this.Total = Total;this.Status = Status; this.TableID = TableID; this.Type = Type;
            db.Order.Add(this);
            db.SaveChanges();
           
        }
        public List<Order> removeOrder(int ID)
        {
            var orders = db.Order.FirstOrDefault(x => x.ID == ID);
            db.Order.Remove(orders);
            db.SaveChanges();
            return viewOrder();
        }
        public List<Order> updateOrder(int ID, int EmployeeID, double
            Total, string Status, int TableID, string Type)
        {
            var orders = db.Order.FirstOrDefault(x => x.ID == ID);
            orders.EmployeeID = EmployeeID; orders.Total = Total; orders.Status = Status; orders.TableID = TableID; orders.Type = Type;
            db.Order.Update(orders);
            db.SaveChanges();
            return viewOrder();
        }
        public List<Order> viewOrder()
        {
            return db.Order.ToList();
        }
        public List<Order> Search(int ID)
        {
            List<Order> orderItem = db.Order.Where(x => x.ID == ID).ToList();
            return orderItem;
        }

        public List<Order> Search(string TableId)
        {
            TableID = int.Parse(TableId);
            List<Order> orderItem = db.Order.Where(x => x.TableID == TableID).ToList();
            return orderItem;
        }
        public List<Order> changeOrderStatus(int TableID, string Status)
        {
            var orders = db.Order.FirstOrDefault(x => x.TableID == TableID);
            orders.Status = Status;
            db.Order.Update(orders);
            db.SaveChanges();
            return viewOrder();
        }
        public List<Order> changeEmployeeOrder(int TableID, int EmployeeID)
        {
            var orders = db.Order.FirstOrDefault(x => x.TableID == TableID);
            orders.EmployeeID = EmployeeID;
            db.Order.Update(orders);
            db.SaveChanges();
            return viewOrder();

        }

     

    }
}
