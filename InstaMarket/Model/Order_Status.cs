using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("order_status")]
    public class Order_Status
    {
        [Key,Column("order_status_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_Status_Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
