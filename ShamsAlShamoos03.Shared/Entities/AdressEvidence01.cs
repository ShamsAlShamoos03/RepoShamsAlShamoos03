 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
    public class AdressEvidence01
    {
         [Key]
        public string? AdressEvidence01ID  { get; set; }
        /// <summary>
        ///  رجه نام و نشان ش کا کد ملی
        /// </summary>
        public string? MelliCode { get; set; }
        [ForeignKey("MelliCode")]
        public virtual TblMaster oo_AdressEvidence01 { get; set; }

        /// <summary>
        ///  گرید 
        /// </summary>
        public string? Grade { get; set; }




        /// <summary>
        ///  آدرس 
        /// </summary>
        public string? Adress01 { get; set; }


        /// <summary>
        ///  آدرس منزل محل کار
        /// </summary>
        public int? HomeOr01Work01 { get; set; }
        [ForeignKey("HomeOr01Work01")]
        public virtual CategoryGeneral oo_HomeOr01Work01 { get; set; }

        /// <summary>
        ///  شهر
        /// </summary>
        public string? City { get; set; }
        [ForeignKey("City")]
        public virtual CityType oo_City { get; set; }



        /// <summary>
        ///  سطح آزمون
        /// </summary>
        public int? LevelExam { get; set; }
        [ForeignKey("LevelExam")]
        public virtual CategoryGeneral oo_LevelExam { get; set; }
        /// <summary>
        /// تاریخ شروع
        /// </summary>
        public string? FromDateAdressEvidence01Title { get; set; }
        /// <summary>
        ///  تاریخ خاتمه
        /// </summary>
        public string? ToDateAdressEvidence01Title { get; set; }
        /// <summary>
        ///  ترتیب
        /// </summary>
        public int? Sortable01Id { get; set; }
        [ForeignKey("Sortable01Id")]
        public virtual Sortable01 Sortable01 { get; set; }

        /// <summary>
        ///  وضعیت قبول مردود
        /// </summary>
        public int? StatusAdressEvidence01 { get; set; }
        [ForeignKey("StatusAdressEvidence01")]
        public virtual CategoryGeneral oo_StatusAdressEvidence01 { get; set; }


        /// <summary>
        ///  فعال غیر فعال
        /// </summary>
        public bool? IsHaveJob { get; set; }    
    }
 