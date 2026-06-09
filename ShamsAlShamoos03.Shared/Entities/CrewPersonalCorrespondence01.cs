using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class CrewPersonalCorrespondence01 : BaseApprovalNavigationEntity
{
    /// <summary>
    ///  تاریخ شمسی
    /// </summary>
    [Key]
    public string? CrewPersonalCorrespondence01ID { get; set; }

    /// <summary>
    //تاریخ
    /// </summary>
    public string? PersonalCorrespondence01ID { get; set; }
    [ForeignKey("PersonalCorrespondence01ID")]
    public virtual PersonalCorrespondence01 oo_PersonalCorrespondence01ID { get; set; }

    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate01 { get; set; }
    [ForeignKey("VarDate01")]
    public virtual DateProperty01 oo_VarDate01 { get; set; }

    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate02 { get; set; }
    [ForeignKey("VarDate02")]
    public virtual DateProperty01 oo_VarDate02 { get; set; }

    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate03 { get; set; }
    [ForeignKey("VarDate03")]
    public virtual DateProperty01 oo_VarDate03 { get; set; }

    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate04 { get; set; }
    [ForeignKey("VarDate04")]
    public virtual DateProperty01 oo_VarDate04 { get; set; }

    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate05 { get; set; }
    [ForeignKey("VarDate05")]
    public virtual DateProperty01 oo_VarDate05 { get; set; }

    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate06 { get; set; }
    [ForeignKey("VarDate06")]
    public virtual DateProperty01 oo_VarDate06 { get; set; }

    /// <summary>
    ///CALL-SIGN
    ///ساعت شروع و خاتمه خدمت
    /// </summary>
    public int? TimwStartEnd01 { get; set; }
    [ForeignKey("TimwStartEnd01")]
    public virtual CategoryGeneral oo_TimwStartEnd01 { get; set; }

    public int? strVariabl01 { get; set; }
    [ForeignKey("strVariabl01")]
    public virtual CategoryGeneral oo_strVariabl01 { get; set; }

    public int? strVariabl02 { get; set; }
    [ForeignKey("strVariabl02")]
    public virtual CategoryGeneral oo_strVariabl02 { get; set; }

    public int? strVariabl03 { get; set; }
    [ForeignKey("strVariabl03")]
    public virtual CategoryGeneral oo_strVariabl03 { get; set; }

    public int? strVariabl04 { get; set; }
    [ForeignKey("strVariabl04")]
    public virtual CategoryGeneral oo_strVariabl04 { get; set; }

    public int? strVariabl05 { get; set; }
    [ForeignKey("strVariabl05")]
    public virtual CategoryGeneral oo_strVariabl05 { get; set; }

    public int? strVariabl06 { get; set; }
    [ForeignKey("strVariabl06")]
    public virtual CategoryGeneral oo_strVariabl06 { get; set; }

    /// <summary>
    /// یگان
    /// </summary>
    public int? UnitID01 { get; set; }
    [ForeignKey("UnitID01")]
    public virtual CategoryGeneral? oo_UnitID01 { get; set; }

    /// <summary>
    ///ساعت شروع و خاتمه خدمت
    /// </summary>
    public string? DatePropertyPlanEvidence01 { get; set; }
    [ForeignKey("DatePropertyPlanEvidence01")]
    public virtual DatePropertyPlanEvidence01 oo_DatePropertyPlanEvidence01 { get; set; }

    /// <summary>
    ///ای دی آمار روزانه 
    /// </summary>
    public string? DailyPlanEvidence01ID { get; set; }
    [ForeignKey("DailyPlanEvidence01ID")]
    public virtual DailyPlanEvidence01 oo_DailyPlanEvidence01ID { get; set; }

    /// <summary>
    //شماره نامه
    /// </summary>
    public string? DocumentNO01 { get; set; }

    /// <summary>
    ///  درجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster oo_CrewDailyPesronel { get; set; }

    /// <summary>
    ///وضعیت آمار روزانه 
    /// </summary>
    public int? StatAmar01 { get; set; }
    [ForeignKey("StatAmar01")]
    public virtual CategoryGeneral oo_StatAmar01 { get; set; }

    /// <summary>
    ///وضعیت آمار روزانه روز قبل  
    /// </summary>
    public int? LastStatAmar01 { get; set; }
    [ForeignKey("LastStatAmar01")]
    public virtual CategoryGeneral oo_LastStatAmar01 { get; set; }

    /// <summary>
    ///توضیجات آمار روزانه 
    /// </summary>
    public int? DesAmar01 { get; set; }
    [ForeignKey("DesAmar01")]
    public virtual CategoryGeneral oo_DesAmar01 { get; set; }

    /// <summary>
    //تاریخ شروع
    /// </summary>
    public string? DateDesAmar01 { get; set; }
    [ForeignKey("DateDesAmar01")]
    public virtual DateProperty01 oo_DateDesAmar01 { get; set; }

    /// <summary>
    //تاریخ پایان
    /// </summary>
    public string? DateDesAmar02 { get; set; }
    [ForeignKey("DateDesAmar02")]
    public virtual DateProperty01 oo_DateDesAmar02 { get; set; }

    /// <summary>
    ///نوع نامه  
    /// </summary>
    public int? TypeLetter01 { get; set; }
    [ForeignKey("TypeLetter01")]
    public virtual CategoryGeneral oo_TypeLetter01 { get; set; }

}
