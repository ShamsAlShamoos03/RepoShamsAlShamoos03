using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public class DateProperty01
    {
        /// <summary>
        ///  تاریخ شمسی
        /// </summary>
        [Key]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "DateProperty01ID must be 8 characters")]
        public string? DateProperty01ID  { get; set; }

        /// <summary>
        ///CALL-SIGN
        ///ساعت شروع و خاتمه خدمت
        /// </summary>
        /// CategoryGeneralSubId=27
        public int? TimwStartEnd01 { get; set; }
        [ForeignKey("TimwStartEnd01")]
        public virtual CategoryGeneral oo_TimwStartEnd01 { get; set; }

}
