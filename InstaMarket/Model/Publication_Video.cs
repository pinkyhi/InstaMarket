using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("publication_video")]
    public class Publication_Video
    {
        [Key, Column("video_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Video_Id { get; set; }
        public string Path { get; set; }
        public string Publication_Id { get; set; }
        public Publication Publication { get; set; }
    }
}
