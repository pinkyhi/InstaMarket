using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("comment")]
    public class Comment
    {
        [Key,Column("comment_id")]
        public long Comment_Id { get; set; }
        public long User_Id { get; set; }
        public string Publication_Id { get; set; }
        public Publication Publication { get; set; }
    }
}
