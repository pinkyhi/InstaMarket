using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("order")]
    public class Order
    {
        [Key,Column("order_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_Id { get; set; }
        public long? User_Id{ get; set; }
        public User User { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public int Delivery_Id { get; set; }
        public Delivery Delivery { get; set; }
        public string Phone_Number { get; set; }
        public int Order_Status_Id { get; set; }
        public Order_Status Order_Status { get; set; }
        public decimal Full_Price { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public List<Receipt> Receipts { get; set; }
    }

}
