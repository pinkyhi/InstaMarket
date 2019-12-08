using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("shop")]
    public class Shop
    {
        [Key,Column("shop_id")]
        public long Shop_Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public List<Publication> Publications { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
