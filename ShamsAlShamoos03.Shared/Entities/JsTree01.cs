using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class JsTree01
    {
        [Key]
        public string JobsID { get; set; }
        public string JobsName { get; set; }
        public string JobsLevel { get; set; }
    }

 