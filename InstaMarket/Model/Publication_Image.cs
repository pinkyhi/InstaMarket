using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("publication_image")]
    public class Publication_Image
    {
        [Key, Column("image_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Image_Id { get; set; }
        public string Path { get; set; }
        public string Publication_Id { get; set; }
        public Publication Publication { get; set; }
    }
}
