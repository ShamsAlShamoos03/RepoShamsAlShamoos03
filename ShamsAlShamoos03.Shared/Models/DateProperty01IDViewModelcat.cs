
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShamsAlShamoos03.Shared.Models
{
    public class DateProperty01ViewModelcat
    {
        /// <summary>
        ///  تاریخ شمسی
        /// </summary>
       public string DateProperty01ID { get; set; }
        public DateTime Miladidate { get; set; }

        /// <summary>
        ///CALL-SIGN
        ///ساعت شروع و خاتمه خدمت
        /// </summary>
        /// CategoryGeneralSubId=27
        public int? TimwStartEnd01 { get; set; }
        public string? strTimwStart01 { get; set; }
        public string? strTimwEnd01 { get; set; }

        public string? strDateCategory01 { get; set; }



    }
}
