

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


    public class DatePropertyPlanEvidence01
    {
         [Key]
        public string? DatePropertyPlanEvidence01ID  { get; set; }
        //public int FactorNumber { get; set; }


        /// <summary>
        ///CALL-SIGN
        ///شناسه رادیویی
        /// </summary>
        /// CategoryGeneralSubId=27
        public int? DateCategory01 { get; set; }
        [ForeignKey("DateCategory01")]
        public virtual CategoryGeneral oo_DateCategory01 { get; set; }



        /// <summary>
        ///ای دی تاریح شمسی 
        /// </summary>
        public string? DateProperty01ID { get; set; }
        [ForeignKey("DateProperty01ID")]
        public virtual DateProperty01 oo_DateProperty01ID { get; set; }


     
        /// <summary>
        ///  فعال غیر فعال
        /// </summary>
        public bool? IsActive { get; set; }

 
}
