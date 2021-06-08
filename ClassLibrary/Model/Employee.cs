using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.Model
{
    [Table("Employee")]
    public class Employee
    {
        DataAccess db = new DataAccess();
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int Rank { get; set; }
        public string Password { get; set; }

        public List<Employee> addEmployee(string Name,string Surname,string Phone,int Rank,string Password)
        {
            this.Name = Name;this.Surname = Surname;this.Phone = Phone;this.Rank = Rank;this.Password=Password;
            db.Employees.Add(this);
            db.SaveChanges();
            return viewEmployee();
        }
        public List<Employee> removeEmployee(int ID)
        {
            var employee = db.Employees.FirstOrDefault(x => x.ID == ID);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return viewEmployee();
        }
        public List<Employee> updateEmployee(int ID,string Name, string Surname, string Phone, int Rank, string Password)
        {
            var employee = db.Employees.FirstOrDefault(x => x.ID == ID);
            employee.Name = Name; employee.Surname = Surname; employee.Phone = Phone; employee.Rank = Rank; employee.Password = Password;employee.ID = ID;
            db.Employees.Update(employee);
            db.SaveChanges();
            return viewEmployee();
        }
        public List<Employee> Search(int ID)
        {
            List<Employee> Employee_ID = db.Employees.Where(p => p.ID == ID).ToList();

            return Employee_ID;
        }

        public List<Employee> Search(string Name)
        {
            List<Employee> Employee_Name = db.Employees.Where(p => p.Name == Name).ToList();

            return Employee_Name;
        }
        public List<Employee> viewEmployee()
        {
            return db.Employees.ToList();
        }
        public int Login(string Name,string Password)
        {
            var employee = db.Employees.FirstOrDefault(x => x.Name == Name && x.Password == Password);
            if (employee != null)
            {
                return employee.Rank;
            }
            else
            {
                return 0;
            }
        }

    }
}
