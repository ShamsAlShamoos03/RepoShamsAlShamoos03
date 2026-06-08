using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class MeetingEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? MeetingEvidence01ID { get; set; }

    /// <summary>
    ///01 کد ملی ثبت کننده
    /// </summary>
    public string? RegisterPesronel01 { get; set; }
    [ForeignKey("RegisterPesronel01")]
    public virtual UjobPesronel01 oo_RegisterPesronel01 { get; set; }


    /// <summary>
    /// منطقه پروازی 
    /// </summary>
    public int? TypeMeeting { get; set; }
    [ForeignKey("TypeMeeting")]
    public virtual CategoryGeneral oo_TypeMeeting { get; set; }

    /// <summary>
    /// منطقه پروازی 
    /// </summary>
    public int? TitleMeeting { get; set; }
    [ForeignKey("TitleMeeting")]
    public virtual CategoryGeneral oo_TitleMeeting { get; set; }

    /// <summary>
    /// منطقه پروازی 
    /// </summary>
    public int? PlaceMeeting { get; set; }
    [ForeignKey("PlaceMeeting")]
    public virtual CategoryGeneral oo_PlaceMeeting { get; set; }

    /// <summary>
    /// منطقه پروازی 
    /// </summary>
    public int? FLTAREANOTAMCHECK { get; set; }
    [ForeignKey("FLTAREANOTAMCHECK")]
    public virtual CategoryGeneral oo_TFLTAREANOTAMCHECK { get; set; }

    /// <summary>
    ///  وضعیت هوا
    /// </summary>
    public int? StatusMeetingEvidence01 { get; set; }
    [ForeignKey("StatusMeetingEvidence01")]
    public virtual CategoryGeneral oo_StatusMeetingEvidence01 { get; set; }

    /// <summary>
    /// تاریخ شروع
    /// </summary>
    public string? FromDateMeetingEvidence01Title { get; set; }

    /// <summary>
    ///  تاریخ خاتمه
    /// </summary>
    public string? ToDateMeetingEvidence01Title { get; set; }

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
