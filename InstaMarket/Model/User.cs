using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.Model
{
    [Table("user")]
    public class User
    {
        [Key,Column("user_id")]
        public long User_Id { get; set; }
        public string User_Name { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Chat> Chats { get; set; }
        public List<Order> Orders { get; set; }
        public override string ToString()
        {
            return User_Name==null?"Null":User_Name;
        }
    }
}
