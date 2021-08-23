using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace titan_ufc_demo.Models
{
    [Table("Users", Schema = "dbo")]
    public class users
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        //public DateTime Created { get; set; }
        //public DateTime UpdatedDate { get; set; }

    }
}
