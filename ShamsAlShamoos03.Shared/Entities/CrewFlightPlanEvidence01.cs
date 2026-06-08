using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CrewFlightPlanEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? CrewFlightPlanEvidence01ID { get; set; }

    /// <summary>
    /// رجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey(nameof(MelliCode))]
    public virtual TblMaster? oo_CrewFlightPesronel { get; set; }

    /// <summary>
    /// ای دی فعالیت پروازی
    /// </summary>
    public string? FlightPlanEvidence01ID { get; set; }
    [ForeignKey(nameof(FlightPlanEvidence01ID))]
    public virtual FlightPlanEvidence01? oo_FlightPlanEvidence01ID { get; set; }

    /// <summary>
    /// آیا PIC است
    /// </summary>
    public bool? IsPIC { get; set; }

    /// <summary>
    /// Duty
    /// </summary>
    public int? Duty { get; set; }
    [ForeignKey(nameof(Duty))]
    public virtual CategoryGeneral? oo_Duty { get; set; }

    /// <summary>
    /// ترتیب
    /// </summary>
    public int? Sortable01Id { get; set; }
    [ForeignKey(nameof(Sortable01Id))]
    public virtual Sortable01? Sortable01 { get; set; }

    /// <summary>
    /// متن نوتم‌ها
    /// </summary>
    public string? NOTAMCHECKETitle01 { get; set; }
    public string? NOTAMCHECKETitle02 { get; set; }
    public string? NOTAMCHECKETitle03 { get; set; }

    /// <summary>
    /// فعال / غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }

    public string? FlightEvidence01ID { get; set; }
    [ForeignKey(nameof(FlightEvidence01ID))]
    public virtual FlightEvidence01? ooRateFlight { get; set; }

    public string? StandCheckWritten01ID { get; set; }
    [ForeignKey(nameof(StandCheckWritten01ID))]
    public virtual StandCheckWritten01? ooStandCheck { get; set; }

    public string? HealthEvidence01ID { get; set; }
    [ForeignKey(nameof(HealthEvidence01ID))]
    public virtual HealthEvidence01? oo_HealthEvidence01 { get; set; }

    public string? NoNoticeEvidence01ID { get; set; }
    [ForeignKey(nameof(NoNoticeEvidence01ID))]
    public virtual NoNoticeEvidence01? oo_NoNoticeEvidence01 { get; set; }

    public string? EnglishExamEvidence01ID { get; set; }
    [ForeignKey(nameof(EnglishExamEvidence01ID))]
    public virtual EnglishExamEvidence01? oo_EnglishExamEvidence01 { get; set; }

    public string? LastfltDateFilnal01 { get; set; }

    [NotMapped]
    public string? DateHealthEvidence01ID => "000dc";
}
