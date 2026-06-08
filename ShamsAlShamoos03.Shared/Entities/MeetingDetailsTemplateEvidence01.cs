using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class MeetingDetailsTemplateEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? MeetingDetailsTemplateEvidence01ID { get; set; }

    /// <summary>
    ///01 کد ملی ثبت کننده
    /// </summary>
    public string? RegisterPesronel01 { get; set; }
    [ForeignKey("RegisterPesronel01")]
    public virtual UjobPesronel01 oo_RegisterPesronel01 { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public string? MeetingConetntEvidence01ID { get; set; }
    [ForeignKey("MeetingConetntEvidence01ID")]
    public virtual MeetingConetntEvidence01 oo_MeetingConetntEvidence01ID { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public string? MeetingEvidence01ID { get; set; }
    [ForeignKey("MeetingEvidence01ID")]
    public virtual MeetingEvidence01 oo_MeetingEvidence01ID { get; set; }


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
    public int? MeetingConetnt { get; set; }
    [ForeignKey("MeetingConetnt")]
    public virtual CategoryGeneral oo_MeetingConetnt { get; set; }

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
    public int? StatusMeetingDetailsTemplateEvidence01 { get; set; }
    [ForeignKey("StatusMeetingDetailsTemplateEvidence01")]
    public virtual CategoryGeneral oo_StatusMeetingDetailsTemplateEvidence01 { get; set; }

    /// <summary>
    /// تاریخ شروع
    /// </summary>
    public string? FromDateMeetingDetailsTemplateEvidence01Title { get; set; }

    /// <summary>
    ///  تاریخ خاتمه
    /// </summary>
    public string? ToDateMeetingDetailsTemplateEvidence01Title { get; set; }

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
