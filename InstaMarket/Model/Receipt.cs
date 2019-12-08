using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("receipt")]
    public class Receipt
    {
        [Key, Column("order_id")]
        public int Order_Id { get; set; }
        public Order Order { get; set; }

        [Key, Column("good_dimension_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Good_Dimension_Id { get; set; }
        public Good_Dimension Good_Dimension{ get; set; }
        public int Amount { get; set; }
        public decimal Position_Price { get; set; }
    }
}
