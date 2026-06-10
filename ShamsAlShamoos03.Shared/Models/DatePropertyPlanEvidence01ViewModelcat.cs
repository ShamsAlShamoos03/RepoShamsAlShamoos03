
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{  
    public class DatePropertyPlanEvidence01ViewModelcat
    {
       public string? DatePropertyPlanEvidence01ID { get; set; }

        /// <summary>
        ///CALL-SIGN
        ///شناسه رادیویی
        /// </summary>
        /// CategoryGeneralSubId=27
        public int? DateCategory01 { get; set; }
        public string? strDateCategory01 { get; set; }


        /// <summary>
        ///ای دی تاریح شمسی 
        /// </summary>
        public string? DateProperty01ID { get; set; }


        /// <summary>
        ///  فعال غیر فعال
        /// </summary>
        public bool? IsActive { get; set; }
        public string IsActivestring { get; set; }

        public string Sortable01Idstring { get; set; }
        

    }





}
