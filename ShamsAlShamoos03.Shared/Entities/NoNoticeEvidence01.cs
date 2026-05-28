 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
    public class NoNoticeEvidence01
    {
         [Key]
        public string? NoNoticeEvidence01ID  { get; set; }
        /// <summary>
        ///  رجه نام و نشان ش کا کد ملی
        /// </summary>
        public string? MelliCode { get; set; }
        [ForeignKey("MelliCode")]
        public virtual TblMaster oo_NoNoticeEvidence01 { get; set; }

        /// <summary>
        ///  گرید 
        /// </summary>
        public string? Grade { get; set; }

        /// <summary>
        ///  سطح آزمون
        /// </summary>
        //public int? LevelExam { get; set; }
        //[ForeignKey("LevelExam")]
        //public virtual CategoryGeneral oo_LevelExam { get; set; }               
        /// <summary>
        /// تاریخ شروع
        /// </summary>
        public string? FromDateNoNoticeEvidence01Title { get; set; }
        /// <summary>
        ///  تاریخ خاتمه
        /// </summary>
        public string? ToDateNoNoticeEvidence01Title { get; set; }
        /// <summary>
        ///  ترتیب
        /// </summary>
        public int? Sortable01Id { get; set; }
        [ForeignKey("Sortable01Id")]
        public virtual Sortable01 Sortable01 { get; set; }

        /// <summary>
        ///  وضعیت قبول مردود
        /// </summary>
        public int? StatusNoNoticeEvidence01 { get; set; }
        [ForeignKey("StatusNoNoticeEvidence01")]
        public virtual CategoryGeneral oo_StatusNoNoticeEvidence01 { get; set; }


        /// <summary>
        ///  فعال غیر فعال
        /// </summary>
        public bool? IsHaveJob { get; set; }    
    }
 