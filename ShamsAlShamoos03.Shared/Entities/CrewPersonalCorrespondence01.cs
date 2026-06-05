using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CrewPersonalCorrespondence01
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

    #region "امضاء کنندگان"
    /// <summary>
    ///01 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel01 { get; set; }
    [ForeignKey("UjobPesronel01")]
    public virtual UjobPesronel01 oo_UjobPesronel01 { get; set; }

    /// <summary>
    ///01 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation01 { get; set; }
    [ForeignKey("StatusConfirmation01")]
    public virtual CategoryGeneral oo_StatusConfirmation01 { get; set; }

    /// <summary>
    ///02 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel02 { get; set; }
    [ForeignKey("UjobPesronel02")]
    public virtual UjobPesronel01 oo_UjobPesronel02 { get; set; }

    /// <summary>
    ///02 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation02 { get; set; }
    [ForeignKey("StatusConfirmation02")]
    public virtual CategoryGeneral oo_StatusConfirmation02 { get; set; }

    /// <summary>
    ///03 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel03 { get; set; }
    [ForeignKey("UjobPesronel03")]
    public virtual UjobPesronel01 oo_UjobPesronel03 { get; set; }

    /// <summary>
    ///03 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation03 { get; set; }
    [ForeignKey("StatusConfirmation03")]
    public virtual CategoryGeneral oo_StatusConfirmation03 { get; set; }

    /// <summary>
    ///04 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel04 { get; set; }
    [ForeignKey("UjobPesronel04")]
    public virtual UjobPesronel01 oo_UjobPesronel04 { get; set; }

    /// <summary>
    ///04 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation04 { get; set; }
    [ForeignKey("StatusConfirmation04")]
    public virtual CategoryGeneral oo_StatusConfirmation04 { get; set; }

    /// <summary>
    ///05 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel05 { get; set; }
    [ForeignKey("UjobPesronel05")]
    public virtual UjobPesronel01 oo_UjobPesronel05 { get; set; }

    /// <summary>
    ///05 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation05 { get; set; }
    [ForeignKey("StatusConfirmation05")]
    public virtual CategoryGeneral oo_StatusConfirmation05 { get; set; }

    /// <summary>
    ///06 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel06 { get; set; }
    [ForeignKey("UjobPesronel06")]
    public virtual UjobPesronel01 oo_UjobPesronel06 { get; set; }

    /// <summary>
    ///06 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation06 { get; set; }
    [ForeignKey("StatusConfirmation06")]
    public virtual CategoryGeneral oo_StatusConfirmation06 { get; set; }

    /// <summary>
    ///07 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel07 { get; set; }
    [ForeignKey("UjobPesronel07")]
    public virtual UjobPesronel01 oo_UjobPesronel07 { get; set; }

    /// <summary>
    ///07 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation07 { get; set; }
    [ForeignKey("StatusConfirmation07")]
    public virtual CategoryGeneral oo_StatusConfirmation07 { get; set; }

    /// <summary>
    ///08 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel08 { get; set; }
    [ForeignKey("UjobPesronel08")]
    public virtual UjobPesronel01 oo_UjobPesronel08 { get; set; }

    /// <summary>
    ///08 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation08 { get; set; }
    [ForeignKey("StatusConfirmation08")]
    public virtual CategoryGeneral oo_StatusConfirmation08 { get; set; }

    /// <summary>
    ///09 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel09 { get; set; }
    [ForeignKey("UjobPesronel09")]
    public virtual UjobPesronel01 oo_UjobPesronel09 { get; set; }

    /// <summary>
    ///09 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation09 { get; set; }
    [ForeignKey("StatusConfirmation09")]
    public virtual CategoryGeneral oo_StatusConfirmation09 { get; set; }

    /// <summary>
    ///10 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel10 { get; set; }
    [ForeignKey("UjobPesronel10")]
    public virtual UjobPesronel01 oo_UjobPesronel10 { get; set; }

    /// <summary>
    ///10 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation10 { get; set; }
    [ForeignKey("StatusConfirmation10")]
    public virtual CategoryGeneral oo_StatusConfirmation10 { get; set; }

    /// <summary>
    ///11 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel11 { get; set; }
    [ForeignKey("UjobPesronel11")]
    public virtual UjobPesronel01 oo_UjobPesronel11 { get; set; }

    /// <summary>
    ///11 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation11 { get; set; }
    [ForeignKey("StatusConfirmation11")]
    public virtual CategoryGeneral oo_StatusConfirmation11 { get; set; }

    /// <summary>
    ///12 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel12 { get; set; }
    [ForeignKey("UjobPesronel12")]
    public virtual UjobPesronel01 oo_UjobPesronel12 { get; set; }

    /// <summary>
    ///12 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation12 { get; set; }
    [ForeignKey("StatusConfirmation12")]
    public virtual CategoryGeneral oo_StatusConfirmation12 { get; set; }

    #endregion
}
