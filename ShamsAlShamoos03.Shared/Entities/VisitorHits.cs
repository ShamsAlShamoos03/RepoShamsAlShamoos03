using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class VisitorHits
    {
        [Key]
        public int id { get; set; }

        public string IpAddress { get; set; }

        public DateTime DateTime { get; set; }

        public int VisitHit { get; set; }
}
