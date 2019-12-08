using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("chat_status")]
    public class Chat_Status
    {
        [Key,Column("chat_status_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Chat_Status_Id { get; set; }
        public string Name { get; set; }
        public List<Chat> Chats { get; set; }
    }
}
