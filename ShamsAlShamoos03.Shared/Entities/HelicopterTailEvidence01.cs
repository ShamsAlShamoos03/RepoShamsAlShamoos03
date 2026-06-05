using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class HelicopterTailEvidence01
{
    [Key]
    public string? HelicopterTailEvidence01ID { get; set; }

    /// <summary>
    ///TotalFlightTime
    /// </summary>
    public string? TotalFlightTime { get; set; }
    public TimeSpan? TotalFlightTimeTimeSpan { get; set; }
    public DateTime? TotalFlightTimeDateTime { get; set; }

    /// <summary>
    ///  شماره بالگرد 
    /// </summary>
    public string? TailHelicopter { get; set; }

    /// <summary>
    ///  سریال بالگرد 
    /// </summary>
    public string? SeriakHelicopter { get; set; }

    /// <summary>
    ///  مدل بالگرد 
    /// </summary>
    public int? TypeHelicopter { get; set; }
    [ForeignKey("TypeHelicopter")]
    public virtual CategoryGeneral oo_TypeHelicopter { get; set; }

    /// <summary>
    ///  وضعیت بالگرد
    /// </summary>
    public int? StatusHelicopterTailEvidence01 { get; set; }
    [ForeignKey("StatusHelicopterTailEvidence01")]
    public virtual CategoryGeneral oo_StatusHelicopterTailEvidence01 { get; set; }

    /// <summary>
    /// یگان
    /// </summary>
    public int? UnitID01 { get; set; }
    [ForeignKey("UnitID01")]
    public virtual CategoryGeneral? oo_tblCategoryGeneralUnit { get; set; }

    /// <summary>
    /// FLIGHT ROLES
    /// 71
    /// </summary>
    public int? FLIGHTROLES { get; set; }
    [ForeignKey("FLIGHTROLES")]
    public virtual CategoryGeneral oo_FLIGHTROLES { get; set; }

    /// <summary>
    /// TYPE OF FLIGHT
    /// 72
    /// </summary>
    public int? TYPEOFFLIGHT { get; set; }
    [ForeignKey("TYPEOFFLIGHT")]
    public virtual CategoryGeneral oo_TYPEOFFLIGHT { get; set; }

    /// <summary>
    /// WAKE TURBULENCE CAL
    /// 73
    /// </summary>
    public int? WAKETURBULENCECAL { get; set; }
    [ForeignKey("WAKETURBULENCECAL")]
    public virtual CategoryGeneral oo_WAKETURBULENCECAL { get; set; }

    /// <summary>
    /// EQUIPMENT AND CAPABILITIES
    /// 74
    /// </summary>
    public int? EQUIPMENTANDCAPABILITIES { get; set; }
    [ForeignKey("EQUIPMENTANDCAPABILITIES")]
    public virtual CategoryGeneral oo_EQUIPMENTANDCAPABILITIES { get; set; }

    /// <summary>
    /// CRUISING SPEED
    /// 75
    /// </summary>
    public int? CRUISINGSPEED { get; set; }
    [ForeignKey("CRUISINGSPEED")]
    public virtual CategoryGeneral oo_CRUISINGSPEED { get; set; }

    /// <summary>
    /// ENDURANCE HR MIN
    /// 76
    /// </summary>
    public int? ENDURANCEHRMIN { get; set; }
    [ForeignKey("ENDURANCEHRMIN")]
    public virtual CategoryGeneral oo_ENDURANCEHRMIN { get; set; }

    /// <summary>
    /// AIRCRAFT COLOUR AND MARKINGS
    /// 77
    /// </summary>
    public int? AIRCRAFTCOLOURANDMARKINGS { get; set; }
    [ForeignKey("AIRCRAFTCOLOURANDMARKINGS")]
    public virtual CategoryGeneral oo_AIRCRAFTCOLOURANDMARKINGS { get; set; }

    /// <summary>
    /// EMERGENCY RADIO
    /// 78
    /// </summary>
    public int? EMERGENCYRADIO { get; set; }
    [ForeignKey("EMERGENCYRADIO")]
    public virtual CategoryGeneral oo_AEMERGENCYRADIO { get; set; }

    /// <summary>
    ///  ترتیب
    /// </summary>
    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}
