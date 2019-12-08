using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("chat")]
    public class Chat
    {
        [Key, Column("chat_id")]
        public string Chat_Id { get; set; }
        public long User_Id { get; set; }
        public User User { get; set; }
        public int Chat_Status_Id { get; set; }
        public Chat_Status Chat_Status { get; set; }
    }
}
