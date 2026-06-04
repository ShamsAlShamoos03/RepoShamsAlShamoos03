using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class NOTAMCHECKEvidence01
{
    [Key]
    public string? NOTAMCHECKEvidence01ID { get; set; }
    /// <summary>
    ///  رجه نام و نشان ش کا کد ملی
    /// </summary>
    //public string? MelliCode { get; set; }
    //[ForeignKey("MelliCode")]
    //public virtual TblMaster oo_NOTAMCHECKEvidence01 { get; set; }

    /// <summary>
    ///  شماره بالگرد 
    /// </summary>
    //public string? TailHelicopter { get; set; }


    /// <summary>
    /// منطقه پروازی 
    /// </summary>
    public int? FLTAREANOTAMCHECK { get; set; }
    [ForeignKey("FLTAREANOTAMCHECK")]
    public virtual CategoryGeneral oo_TFLTAREANOTAMCHECK { get; set; }
    /// <summary>
    ///  وضعیت هوا
    /// </summary>
    public int? StatusNOTAMCHECKEvidence01 { get; set; }
    [ForeignKey("StatusNOTAMCHECKEvidence01")]
    public virtual CategoryGeneral oo_StatusNOTAMCHECKEvidence01 { get; set; }

    /// <summary>
    ///  گرید 
    /// </summary>
    //public string? Grade { get; set; }

    /// <summary>
    ///  سطح آزمون
    /// </summary>
    //public int? LevelExam { get; set; }
    //[ForeignKey("LevelExam")]
    //public virtual CategoryGeneral oo_LevelExam { get; set; }
    /// <summary>
    /// تاریخ شروع
    /// </summary>
    public string? FromDateNOTAMCHECKEvidence01Title { get; set; }
    /// <summary>
    ///  تاریخ خاتمه
    /// </summary>
    public string? ToDateNOTAMCHECKEvidence01Title { get; set; }
    /// <summary>
    ///  ترتیب
    /// </summary>
    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }


    /// <summary>
    /// متن نوتم 01
    /// </summary>
    public string? NOTAMCHECKETitle01 { get; set; }

    /// <summary>
    /// متن نوتم 02
    /// </summary>
    public string? NOTAMCHECKETitle02 { get; set; }

    /// <summary>
    /// متن نوتم 03
    /// </summary>
    public string? NOTAMCHECKETitle03 { get; set; }


    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}
