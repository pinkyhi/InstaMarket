using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("delivery")]
    public class Delivery
    {
        [Key,Column("delivery_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Delivery_Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Num { get; set; }
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return City+", "+Name+" (Num: "+Num+")";
        }
    }
}
