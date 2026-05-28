using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


    public class Advertise
    {
        [Key]
        public int AdId { get; set; }
        public string? gifPath { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Link { get; set; }
        public byte flag { get; set; }
        public byte Advlocation { get; set; }

}
