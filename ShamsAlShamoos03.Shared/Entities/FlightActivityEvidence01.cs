using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class FlightActivityEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? FlightActivityEvidence01ID { get; set; }

    /// <summary>
    /// 01 کد ملی ثبت کننده
    /// </summary>
    public string? RegisterPesronel01 { get; set; }
    [ForeignKey(nameof(RegisterPesronel01))]
    public virtual UjobPesronel01? oo_RegisterPesronel01 { get; set; }

    /// <summary>
    /// یگان
    /// </summary>
    public int? UnitID01 { get; set; }
    [ForeignKey(nameof(UnitID01))]
    public virtual CategoryGeneral? oo_UnitID01 { get; set; }

    /// <summary>
    /// منطقه پروازی
    /// </summary>
    public int? FLTAREANOTAMCHECK { get; set; }
    [ForeignKey(nameof(FLTAREANOTAMCHECK))]
    public virtual CategoryGeneral? oo_TFLTAREANOTAMCHECK { get; set; }

    /// <summary>
    /// وضعیت هوا
    /// </summary>
    public int? StatusFlightActivityEvidence01 { get; set; }
    [ForeignKey(nameof(StatusFlightActivityEvidence01))]
    public virtual CategoryGeneral? oo_StatusFlightActivityEvidence01 { get; set; }

    /// <summary>
    /// تاریخ شروع
    /// </summary>
    public string? FromDateFlightActivityEvidence01Title { get; set; }

    /// <summary>
    /// تاریخ خاتمه
    /// </summary>
    public string? ToDateFlightActivityEvidence01Title { get; set; }

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
}
