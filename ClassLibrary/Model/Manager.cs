using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    [Table("Employee")]
    public class Manager : Employee
    {
        DataAccess db = new DataAccess();

        public int R { get; set; }

        public List<Employee> Promote_Demote(int R)
        {
            var q = db.Employees.FirstOrDefault(x => x.ID == ID);
            q.Rank = R;
            db.Employees.Update(q);
            db.SaveChanges();

            return viewEmployee();
        }
    }
}
