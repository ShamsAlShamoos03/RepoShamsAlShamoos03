using System.ComponentModel.DataAnnotations.Schema;

public abstract class BaseFlightNavigationEntity : BaseApprovalNavigationEntity
{
    /// <summary>
    /// ETD
    /// </summary>
    public string? ETD { get; set; }
    public TimeSpan? ETDTimeSpan { get; set; }
    public DateTime? ETDDateTime { get; set; }

    /// <summary>
    /// ETE
    /// </summary>
    public string? ETE { get; set; }
    public DateTime? ETEDateTime { get; set; }
    public TimeSpan? ETETimeSpan { get; set; }

    /// <summary>
    /// SerialNOPlan
    /// </summary>
    public string? SerialNOPlan { get; set; }

    /// <summary>
    /// ALT
    /// ارتفاع ترافیک
    /// </summary>
    public int? ALT { get; set; }

    [ForeignKey(nameof(ALT))]
    public virtual CategoryGeneral? oo_ALT { get; set; }

    /// <summary>
    /// VHF(G)
    /// </summary>
    public int? VHFG { get; set; }

    [ForeignKey(nameof(VHFG))]
    public virtual CategoryGeneral? oo_VHFG { get; set; }

    /// <summary>
    /// UHF(G)
    /// </summary>
    public int? UHFG { get; set; }

    [ForeignKey(nameof(UHFG))]
    public virtual CategoryGeneral? oo_UHFG { get; set; }

    /// <summary>
    /// FM(G)
    /// </summary>
    public int? FMG { get; set; }

    [ForeignKey(nameof(FMG))]
    public virtual CategoryGeneral? oo_FMG { get; set; }

    /// <summary>
    /// VHF
    /// </summary>
    public int? VHF { get; set; }

    [ForeignKey(nameof(VHF))]
    public virtual CategoryGeneral? oo_VHF { get; set; }

    /// <summary>
    /// UHF
    /// </summary>
    public int? UHF { get; set; }

    [ForeignKey(nameof(UHF))]
    public virtual CategoryGeneral? oo_UHF { get; set; }

    /// <summary>
    /// ADF
    /// </summary>
    public int? ADF { get; set; }

    [ForeignKey(nameof(ADF))]
    public virtual CategoryGeneral? oo_ADF { get; set; }

    /// <summary>
    /// VOR
    /// </summary>
    public int? VOR { get; set; }

    [ForeignKey(nameof(VOR))]
    public virtual CategoryGeneral? oo_VOR { get; set; }

    /// <summary>
    /// RADAR
    /// </summary>
    public int? RADAR { get; set; }

    [ForeignKey(nameof(RADAR))]
    public virtual CategoryGeneral? oo_RADAR { get; set; }

    /// <summary>
    /// ATIS
    /// </summary>
    public int? ATIS { get; set; }

    [ForeignKey(nameof(ATIS))]
    public virtual CategoryGeneral? oo_ATIS { get; set; }

    /// <summary>
    /// PURPOSE OF FLT
    /// </summary>
    public int? PURPOSEOFFLT { get; set; }

    [ForeignKey(nameof(PURPOSEOFFLT))]
    public virtual CategoryGeneral? oo_PURPOSEOFFLT { get; set; }

    /// <summary>
    /// هواشناسی
    /// </summary>
    public string? WeatherEvidence01ID { get; set; }

    [ForeignKey(nameof(WeatherEvidence01ID))]
    public virtual WeatherEvidence01? oo_WeatherEvidence01 { get; set; }

    /// <summary>
    /// منطقه پروازی
    /// </summary>
    public int? FLTAREANOTAMCHECK { get; set; }

    [ForeignKey(nameof(FLTAREANOTAMCHECK))]
    public virtual CategoryGeneral? oo_TFLTAREANOTAMCHECK { get; set; }

    /// <summary>
    /// ترتیب
    /// </summary>
    public int? Sortable01Id { get; set; }

    [ForeignKey(nameof(Sortable01Id))]
    public virtual Sortable01? Sortable01 { get; set; }

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
    /// فعال / غیرفعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}
