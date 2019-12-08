using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("publication")]
    public class Publication
    {
        [Key,Column("publication_id")]
        public string Publication_Id { get; set; }
        public long Shop_Id { get; set; }
        public Shop Shop { get; set; }
        public DateTime Date { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Good_Dimension_Publication> Good_Dimension_Publications { get; set; }
        public List<Publication_Image> Publication_Images { get; set; }
        public List<Publication_Video> Publication_Videos { get; set; }

    }
}
