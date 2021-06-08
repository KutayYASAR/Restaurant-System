using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.Model
{
    [Table("Reservation")]
    public class Reservation
    {
        DataAccess db = new DataAccess();
        public int ID { get; set; }
        public string Date { get; set; }
        public int TableID { get; set; }
        public string CustomerName { get; set; }
        public string Info { get; set; }
        public string Status { get; set; }

        public List<Reservation> addReservation( string Date, int TableID, string CustomerName, string Info, string Status)
        {
            this.Date = Date; this.TableID = TableID; this.CustomerName = CustomerName;this.Info = Info;this.Status = Status;
            db.Reservations.Add(this);
            db.SaveChanges();
            return viewReservation();
        }

        public List<Reservation> removeReservation(int ID)
        {
            var reservationItem = db.Reservations.FirstOrDefault(x => x.ID == ID);
            db.Reservations.Remove(reservationItem);
            db.SaveChanges();
            return viewReservation();
        }
        public List<Reservation> updateReservation(int ID, string Date, int TableID, string CustomerName, string Info, string Status)
        {
            var reservationItem = db.Reservations.FirstOrDefault(x => x.ID == ID);
            reservationItem.Date = Date; reservationItem.TableID = TableID; reservationItem.CustomerName = CustomerName; reservationItem.Info = Info; reservationItem.Status = Status;
            db.Reservations.Update(reservationItem);
            db.SaveChanges();
            return viewReservation();
        }
        public List<Reservation> viewReservation()
        {
            return db.Reservations.ToList();
        }
        public List<Reservation> Search(int ID)
        {
            List<Reservation> reservationItem = db.Reservations.Where(x => x.ID == ID).ToList();
            return reservationItem;
        }
        public List<Reservation> Search(string TableId)
        {
            TableID = int.Parse(TableId);
            List<Reservation> reservationItem = db.Reservations.Where(x => x.TableID == TableID).ToList();
            return reservationItem;
        }
    }
}
