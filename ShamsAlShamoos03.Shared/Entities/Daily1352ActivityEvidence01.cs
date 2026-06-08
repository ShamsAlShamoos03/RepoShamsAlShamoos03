using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352ActivityEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? Daily1352ActivityEvidence01ID { get; set; }

    /// <summary>
    ///01 کد ملی ثبت کننده
    /// </summary>
    public string? RegisterPesronel01 { get; set; }
    [ForeignKey("RegisterPesronel01")]
    public virtual UjobPesronel01 oo_RegisterPesronel01 { get; set; }

    /// <summary>
    /// یگان
    /// </summary>
    public int? UnitID01 { get; set; }
    [ForeignKey("UnitID01")]
    public virtual CategoryGeneral? oo_UnitID01 { get; set; }

    /// <summary>
    /// ای دی و نام پابگاه 
    /// </summary>
    public string? Daily1352ActivityEvidence01IDStateName01 { get; set; }

    /// <summary>
    /// نام پابگاه 
    /// </summary>
    public int? StateName01 { get; set; }
    [ForeignKey("StateName01")]
    public virtual CategoryGeneral oo_StateName01 { get; set; }

    /// <summary>
    //تاریخ
    /// </summary>
    public string? FromDateDaily1352ActivityEvidence01Title { get; set; }
    [ForeignKey("FromDateDaily1352ActivityEvidence01Title")]
    public virtual DateProperty01 oo_FromDateDaily1352ActivityEvidence01Title { get; set; }

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
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}
