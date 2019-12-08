using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("good_dimension_publication")]
    public class Good_Dimension_Publication
    {
        [Key,Column("good_dimension_id")]
        public int Good_Dimension_Id { get; set; }
        public Good_Dimension Good_Dimension { get; set; }

        [Key, Column("publication_id")]
        public string Publication_Id { get; set; }
        public Publication Publication { get; set; }
    }
}
