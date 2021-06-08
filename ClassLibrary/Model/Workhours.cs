using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ClassLibrary.Model
{
    [Table("WorkHours")]
    public class Workhours
    {
        DataAccess db = new DataAccess();
        
        public int ID { get; set; }
        public string Time { get; set; }

        public int Emp_id { get; set; }

        public List<Workhours> addworkhours(string Time,int Emp_id)
        {
           
            this.Time = Time;
            this.Emp_id = Emp_id;
            db.Workhours.Add(this);
            db.SaveChanges();
            return viewWorkhours();
        }

        public List<Workhours> deleteworkhours(int WH_ID)
        {
            


            var x = db.Workhours.FirstOrDefault(p => p.Emp_id == Emp_id);
            db.Workhours.Remove(x);
            db.SaveChanges();

            return viewWorkhours();
        }


        public List<Workhours> updateworkhours( string Time, int Emp_id)
        {
            var x = db.Workhours.FirstOrDefault(p => p.Emp_id == Emp_id);
            
            this.Time = Time;
            this.Emp_id = Emp_id;
            db.Workhours.Update(this);
            return viewWorkhours();


        }

        public List<Workhours> viewWorkhours()
        {
            return db.Workhours.ToList();
        }
    }
}
