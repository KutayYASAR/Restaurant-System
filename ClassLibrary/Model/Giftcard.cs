
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.Model
{
    [Table("GiftCard")]
    public class Giftcard
    {
        public string Code { get; set; }
        public int ID { get; set; }
        public float Balance { get; set; }
        DataAccess db = new DataAccess();
        private static string RandomString(int length)
        {
            var random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var builder = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                var c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }
        public List<Giftcard> addGiftcard(float Balance )
        {
            this.Code = RandomString(16);this.Balance = Balance;
            db.Giftcards.Add(this);
            db.SaveChanges();
            return viewGiftcards();
        }
        public List<Giftcard> Search(int ID)
        {
            List<Giftcard> tableItem = db.Giftcards.Where(x => x.ID == ID).ToList();
            return tableItem;
        }
        public List<Giftcard> Search(string Code)
        {
            List<Giftcard> tableItem = db.Giftcards.Where(x => x.Code == Code).ToList();
            return tableItem;
        }
        public List<Giftcard> updateGiftcard(string code,float Balance )
        {
            var card = db.Giftcards.FirstOrDefault(x => x.Code == code);
            card.Balance -= Balance;
            db.Giftcards.Update(card);
            db.SaveChanges();
            return viewGiftcards();
        }        
        public List<Giftcard> removeGiftcard(string code)
        {
            var card = db.Giftcards.FirstOrDefault(x => x.Code == code);
            db.Giftcards.Remove(card);
            db.SaveChanges();
            return viewGiftcards();
        }

        public List<Giftcard> viewGiftcards()
        {
            return db.Giftcards.ToList();
        }
    }
}
