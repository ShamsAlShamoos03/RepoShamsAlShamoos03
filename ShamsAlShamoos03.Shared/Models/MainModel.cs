
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{

    public class MainModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // فرض بر اینکه این اطلاعات در زمان لود وجود داره
        public List<SecondModel> Details { get; set; }
    }

    public class SecondModel
    {
        public int SubId { get; set; }
        public string Detail { get; set; }
    }



}
