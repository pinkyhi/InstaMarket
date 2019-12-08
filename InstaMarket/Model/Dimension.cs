using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("dimension")]
    public class Dimension
    {
        [Key,Column("dimension_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Dimension_Id { get; set; }
        public string Amount { get; set; }
        public string Measure { get; set; }
        public List<Good_Dimension> Good_Dimensions { get; set; }

        public override string ToString()
        {
            return Amount +"("+Measure+")";
        }
    }
}
