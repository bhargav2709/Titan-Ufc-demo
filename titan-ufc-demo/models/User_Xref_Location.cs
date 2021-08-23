using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace titan_ufc_demo.Models
{
    [Table("User_Xref_Location", Schema = "dbo")]
    public class User_Xref_Location
    {
        [Key]
        public int User_Xref_LocationId { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }
    }
}
