
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class JsTree_01ViewModel
    {
        public string id { get; set; }
        public string parent { get; set; }
        public string text { get; set; }
        //public int JobsID { get; set; }
        //public string JobsName { get; set; }
        //public int JobsLevel { get; set; }

    }
    public class Diagram_01ViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ReportingPerson { get; set; }
        public string Image { get; set; }

        //public string id { get; set; }
        //public string parent { get; set; }
        //public string text { get; set; }
        //public int JobsID { get; set; }
        //public string JobsName { get; set; }
        //public int JobsLevel { get; set; }

    }
}
