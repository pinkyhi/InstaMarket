using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace InstaMarket.Model
{
    [Table("good")]
    public class Good
    {

        [Column("good_id"), Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Good_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Good_Dimension> Good_Dimensions { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

