using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ClassLibrary.Model
{
    public class DataAccess: DbContext
    {
        public DataAccess() : base()
        {

        }
        public DbSet<Menu> MenuItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<MenutoCart> Cart { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Giftcard> Giftcards { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Payment> Payment { get; set; }

        public DbSet<Workhours> Workhours { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            optionsBuilder.UseSqlServer(conString);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
