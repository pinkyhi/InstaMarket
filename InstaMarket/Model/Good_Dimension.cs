using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("good_dimension")]
    public class Good_Dimension
    {
        [Key,Column("good_dimension_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Good_Dimension_Id { get; set; }
        public decimal Price { get; set; }
        public int Available { get; set; }
        public int Dimension_Id { get; set; }   // Index
        public Dimension Dimension { get; set; }
        public int Good_Id { get; set; }    // Index 
        public Good Good { get; set; }
        public List<Receipt> Receipts { get; set; }
        public List<Good_Dimension_Publication> Good_Dimension_Publications { get; set; }

        public override string ToString()
        {
            return (Good==null ? "" : Good.ToString()) +" "+ (Dimension==null ? "" : Dimension.ToString());
        }
    }
}
