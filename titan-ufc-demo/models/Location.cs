using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace titan_ufc_demo.Models
{
    [Table("Location", Schema = "dbo")]
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        //public DateTime Created { get; set; }
        //public DateTime UpdatedDate { get; set; }

    }
}
