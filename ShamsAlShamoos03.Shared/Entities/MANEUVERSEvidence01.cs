using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class MANEUVERSEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? MANEUVERSEvidence01ID { get; set; }

    /// <summary>
    ///ریت خلبان یکم 
    /// </summary>
    public int? Rate01 { get; set; }
    [ForeignKey("Rate01")]
    public virtual CategoryGeneral oo_Rate01 { get; set; }

    /// <summary>
    ///ریت خلبان دوم 
    /// </summary>
    public int? Rate02 { get; set; }
    [ForeignKey("Rate02")]
    public virtual CategoryGeneral oo_Rate02 { get; set; }

    /// <summary>
    ///مدل بالکرد 
    /// </summary>
    public int? ModelAc { get; set; }
    [ForeignKey("ModelAc")]
    public virtual CategoryGeneral oo_ModelAc { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public string? FlightActivityEvidence01ID { get; set; }
    [ForeignKey("FlightActivityEvidence01ID")]
    public virtual FlightActivityEvidence01 oo_FlightActivityEvidence01ID { get; set; }

    /// <summary>
    ///شماره و مدل بالگرد 
    /// </summary>
    public string? HelicopterTailEvidence01 { get; set; }
    [ForeignKey("HelicopterTailEvidence01")]
    public virtual HelicopterTailEvidence01 oo_HelicopterTailEvidence01 { get; set; }

    /// <summary>
    ///CALL-SIGN
    ///شناسه رادیویی
    /// </summary>
    public int? CALLSIGN { get; set; }
    [ForeignKey("CALLSIGN")]
    public virtual CategoryGeneral oo_CALLSIGN { get; set; }

    /// <summary>
    ///FLT AREA
    ///منطقه پروازی
    /// </summary>
    public int? FLTAREA { get; set; }
    [ForeignKey("FLTAREA")]
    public virtual CategoryGeneral oo_FLTAREA { get; set; }

    /// <summary>
    ///ETD
    /// </summary>
    public string? ETD { get; set; }
    public TimeSpan? ETDTimeSpan { get; set; }
    public DateTime? ETDDateTime { get; set; }

    /// <summary>
    ///ETE
    /// </summary>
    public string? ETE { get; set; }
    public DateTime? ETEDateTime { get; set; }
    public TimeSpan? ETETimeSpan { get; set; }

    /// <summary>
    /// SerialNOPlan
    /// </summary>
    public string? SerialNOPlan { get; set; }

    /// <summary>
    ///ALT
    ///ارتفاع ترافیک
    /// </summary>
    public int? ALT { get; set; }
    [ForeignKey("ALT")]
    public virtual CategoryGeneral oo_ALT { get; set; }

    /// <summary>
    ///VHF(G)
    ///فرکانس رادیویی 
    /// </summary>
    public int? VHFG { get; set; }
    [ForeignKey("VHFG")]
    public virtual CategoryGeneral oo_VHFG { get; set; }

    /// <summary>
    ///UHF(G)
    ///فرکانس رادیویی 
    /// </summary>
    public int? UHFG { get; set; }
    [ForeignKey("UHFG")]
    public virtual CategoryGeneral oo_UHFG { get; set; }

    /// <summary>
    ///FM(G)
    ///فرکانس رادیویی 
    /// </summary>
    public int? FMG { get; set; }
    [ForeignKey("FMG")]
    public virtual CategoryGeneral oo_FMG { get; set; }

    /// <summary>
    ///VHF
    ///فرکانس رادیویی 
    /// </summary>
    public int? VHF { get; set; }
    [ForeignKey("VHF")]
    public virtual CategoryGeneral oo_VHF { get; set; }

    /// <summary>
    ///UHF
    ///فرکانس رادیویی 
    /// </summary>
    public int? UHF { get; set; }
    [ForeignKey("UHF")]
    public virtual CategoryGeneral oo_UHF { get; set; }

    /// <summary>
    ///ADF
    ///فرکانس رادیویی 
    /// </summary>
    public int? ADF { get; set; }
    [ForeignKey("ADF")]
    public virtual CategoryGeneral oo_ADF { get; set; }

    /// <summary>
    ///VOR
    ///فرکانس رادیویی 
    /// </summary>
    public int? VOR { get; set; }
    [ForeignKey("VOR")]
    public virtual CategoryGeneral oo_VOR { get; set; }

    /// <summary>
    ///RADAR
    ///فرکانس رادیویی 
    /// </summary>
    public int? RADAR { get; set; }
    [ForeignKey("RADAR")]
    public virtual CategoryGeneral oo_RADAR { get; set; }

    /// <summary>
    ///ATIS
    ///فرکانس رادیویی 
    /// </summary>
    public int? ATIS { get; set; }
    [ForeignKey("ATIS")]
    public virtual CategoryGeneral oo_ATIS { get; set; }

    /// <summary>
    ///PURPOSE OF FLT
    ///نوع فعالیت 
    /// </summary>
    public int? PURPOSEOFFLT { get; set; }
    [ForeignKey("PURPOSEOFFLT")]
    public virtual CategoryGeneral oo_PURPOSEOFFLT { get; set; }

    /// <summary>
    ///هواشناسی
    /// </summary>
    public string? WeatherEvidence01ID { get; set; }
    [ForeignKey("WeatherEvidence01ID")]
    public virtual WeatherEvidence01 oo_WeatherEvidence01 { get; set; }


    /// <summary>
    /// منطقه پروازی 
    /// </summary>
    public int? FLTAREANOTAMCHECK { get; set; }
    [ForeignKey("FLTAREANOTAMCHECK")]
    public virtual CategoryGeneral oo_TFLTAREANOTAMCHECK { get; set; }

    /// <summary>
    ///  وضعیت هوا
    /// </summary>
    public int? StatusMANEUVERSEvidence01 { get; set; }
    [ForeignKey("StatusMANEUVERSEvidence01")]
    public virtual CategoryGeneral oo_StatusMANEUVERSEvidence01 { get; set; }

    /// <summary>
    /// تاریخ شروع
    /// </summary>
    public string? FromDateMANEUVERSEvidence01Title { get; set; }

    /// <summary>
    ///  تاریخ خاتمه
    /// </summary>
    public string? ToDateMANEUVERSEvidence01Title { get; set; }

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

    public bool? HoverFLT { get; set; }
    public bool? SidwardFLT { get; set; }
    public bool? BackwardFLT { get; set; }
    public bool? NormalTO { get; set; }
    public bool? IGEcheck { get; set; }
    public bool? OGEcheck { get; set; }
    public bool? NormalAPP { get; set; }
    public bool? SteepAPP { get; set; }
    public bool? MaxTO { get; set; }
    public bool? APP180 { get; set; }
    public bool? MinpowerTO { get; set; }
    public bool? Internalload { get; set; }
    public bool? Externalload { get; set; }
    public bool? ConfindOPS { get; set; }
    public bool? PinnacleOPS { get; set; }
    public bool? SLOPOPS { get; set; }
    public bool? NOEFLT { get; set; }
    public bool? FMDFOPS { get; set; }
    public bool? Pricaurionarylanding { get; set; }
    public bool? Forcedlanding { get; set; }
    public bool? SingleENG { get; set; }
    public bool? HYDMAL { get; set; }
    public bool? ManualGOVOPS { get; set; }
    public bool? Runinglanding { get; set; }
    public bool? HoveringAUTO { get; set; }
    public bool? StandardAUTO { get; set; }
    public bool? LowlevelAUTO { get; set; }
    public bool? Lowlevelflt { get; set; }
    public bool? AUTOTWP { get; set; }
    public bool? AUTO180 { get; set; }
    public bool? WaterOPS { get; set; }
    public bool? gunnery { get; set; }
    public bool? HoodFLT { get; set; }
    public bool? INSTFLT { get; set; }
    public bool? AntiTorqueFailure { get; set; }
}
