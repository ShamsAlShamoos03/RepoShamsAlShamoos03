using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class MeetingMembersEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? MeetingMembersEvidence01ID { get; set; }

    /// <summary>
    ///01 کد ملی ثبت کننده
    /// </summary>
    public string? MeetingDetailsEvidence01ID { get; set; }
    [ForeignKey("MeetingDetailsEvidence01ID")]
    public virtual MeetingDetailsEvidence01 oo_MeetingDetailsEvidence01ID { get; set; }

    /// <summary>
    ///  رجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster oo_CrewFlightPesronel { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public string? FlightPlanEvidence01ID { get; set; }
    [ForeignKey("FlightPlanEvidence01ID")]
    public virtual FlightPlanEvidence01 oo_FlightPlanEvidence01ID { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public bool? IsPIC { get; set; }

    public int? Duty { get; set; }
    [ForeignKey("Duty")]
    public virtual CategoryGeneral oo_Duty { get; set; }


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
