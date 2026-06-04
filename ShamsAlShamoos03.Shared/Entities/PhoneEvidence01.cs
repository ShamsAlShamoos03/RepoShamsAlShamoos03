using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PhoneEvidence01
{
    [Key]
    public string? PhoneEvidence01ID { get; set; }
    /// <summary>
    ///  رجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster oo_PhoneEvidence01 { get; set; }

    /// <summary>
    ///  گرید 
    /// </summary>
    public string? Grade { get; set; }


    /// <summary>
    ///  تلفن 
    /// </summary>
    public string? Phone01 { get; set; }


    /// <summary>
    ///  ثابت همراه
    /// </summary>
    public int? MobileorPhone01 { get; set; }
    [ForeignKey("MobileorPhone01")]
    public virtual CategoryGeneral oo_MobileorPhone01 { get; set; }

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
    public string? FromDatePhoneEvidence01Title { get; set; }
    /// <summary>
    ///  تاریخ خاتمه
    /// </summary>
    public string? ToDatePhoneEvidence01Title { get; set; }
    /// <summary>
    ///  ترتیب
    /// </summary>
    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

    /// <summary>
    ///  وضعیت قبول مردود
    /// </summary>
    public int? StatusPhoneEvidence01 { get; set; }
    [ForeignKey("StatusPhoneEvidence01")]
    public virtual CategoryGeneral oo_StatusPhoneEvidence01 { get; set; }


    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}
