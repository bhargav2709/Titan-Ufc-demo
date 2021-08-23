using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace titan_ufc_demo.Models
{
    [Table("Device", Schema = "dbo")]
    public class Devices
    {
        //[Key]
        //public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public string DeviceType { get; set; }

        //public DateTime Created { get; set; }
        //public DateTime UpdatedDate { get; set; }

    }
}

namespace titan_ufc_demo.Models.test
{
    public class Devices
    {
        public string DeviceName { get; set; }
        public int LocationId { get; set; }
        public string DeviceType { get; set; }


    }
}
