using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

public class CrewGaurdPlanEvidence01
{
    [Key]
    public string? CrewGaurdPlanEvidence01ID { get; set; }

    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster oo_CrewGaurdPesronel { get; set; }

    public string? GaurdPlanEvidence01ID { get; set; }
    [ForeignKey("GaurdPlanEvidence01ID")]
    public virtual GaurdPlanEvidence01 oo_GaurdPlanEvidence01ID { get; set; }

    public bool? IsPIC { get; set; }
    public int? Duty { get; set; }
    [ForeignKey("Duty")]
    public virtual CategoryGeneral oo_Duty { get; set; }

    // ======= 12 تاییدکننده و وضعیت =======
    public string? UjobPesronel01 { get; set; }
    public int? StatusConfirmation01 { get; set; }

    public string? UjobPesronel02 { get; set; }
    public int? StatusConfirmation02 { get; set; }

    public string? UjobPesronel03 { get; set; }
    public int? StatusConfirmation03 { get; set; }

    public string? UjobPesronel04 { get; set; }
    public int? StatusConfirmation04 { get; set; }

    public string? UjobPesronel05 { get; set; }
    public int? StatusConfirmation05 { get; set; }

    public string? UjobPesronel06 { get; set; }
    public int? StatusConfirmation06 { get; set; }

    public string? UjobPesronel07 { get; set; }
    public int? StatusConfirmation07 { get; set; }

    public string? UjobPesronel08 { get; set; }
    public int? StatusConfirmation08 { get; set; }

    public string? UjobPesronel09 { get; set; }
    public int? StatusConfirmation09 { get; set; }

    public string? UjobPesronel10 { get; set; }
    public int? StatusConfirmation10 { get; set; }

    public string? UjobPesronel11 { get; set; }
    public int? StatusConfirmation11 { get; set; }

    public string? UjobPesronel12 { get; set; }
    public int? StatusConfirmation12 { get; set; }

    // ======= ForeignKeys مرتبط با تاییدکنندگان =======
    [ForeignKey("UjobPesronel01")]
    public virtual UjobPesronel01 oo_UjobPesronel01 { get; set; }
    [ForeignKey("StatusConfirmation01")]
    public virtual CategoryGeneral oo_StatusConfirmation01 { get; set; }

    [ForeignKey("UjobPesronel02")]
    public virtual UjobPesronel01 oo_UjobPesronel02 { get; set; }
    [ForeignKey("StatusConfirmation02")]
    public virtual CategoryGeneral oo_StatusConfirmation02 { get; set; }

    [ForeignKey("UjobPesronel03")]
    public virtual UjobPesronel01 oo_UjobPesronel03 { get; set; }
    [ForeignKey("StatusConfirmation03")]
    public virtual CategoryGeneral oo_StatusConfirmation03 { get; set; }

    [ForeignKey("UjobPesronel04")]
    public virtual UjobPesronel01 oo_UjobPesronel04 { get; set; }
    [ForeignKey("StatusConfirmation04")]
    public virtual CategoryGeneral oo_StatusConfirmation04 { get; set; }

    [ForeignKey("UjobPesronel05")]
    public virtual UjobPesronel01 oo_UjobPesronel05 { get; set; }
    [ForeignKey("StatusConfirmation05")]
    public virtual CategoryGeneral oo_StatusConfirmation05 { get; set; }

    [ForeignKey("UjobPesronel06")]
    public virtual UjobPesronel01 oo_UjobPesronel06 { get; set; }
    [ForeignKey("StatusConfirmation06")]
    public virtual CategoryGeneral oo_StatusConfirmation06 { get; set; }

    [ForeignKey("UjobPesronel07")]
    public virtual UjobPesronel01 oo_UjobPesronel07 { get; set; }
    [ForeignKey("StatusConfirmation07")]
    public virtual CategoryGeneral oo_StatusConfirmation07 { get; set; }

    [ForeignKey("UjobPesronel08")]
    public virtual UjobPesronel01 oo_UjobPesronel08 { get; set; }
    [ForeignKey("StatusConfirmation08")]
    public virtual CategoryGeneral oo_StatusConfirmation08 { get; set; }

    [ForeignKey("UjobPesronel09")]
    public virtual UjobPesronel01 oo_UjobPesronel09 { get; set; }
    [ForeignKey("StatusConfirmation09")]
    public virtual CategoryGeneral oo_StatusConfirmation09 { get; set; }

    [ForeignKey("UjobPesronel10")]
    public virtual UjobPesronel01 oo_UjobPesronel10 { get; set; }
    [ForeignKey("StatusConfirmation10")]
    public virtual CategoryGeneral oo_StatusConfirmation10 { get; set; }

    [ForeignKey("UjobPesronel11")]
    public virtual UjobPesronel01 oo_UjobPesronel11 { get; set; }
    [ForeignKey("StatusConfirmation11")]
    public virtual CategoryGeneral oo_StatusConfirmation11 { get; set; }

    [ForeignKey("UjobPesronel12")]
    public virtual UjobPesronel01 oo_UjobPesronel12 { get; set; }
    [ForeignKey("StatusConfirmation12")]
    public virtual CategoryGeneral oo_StatusConfirmation12 { get; set; }

    // ======= متد helper برای کاهش Duplication =======
    [NotMapped]
    public IEnumerable<(string? UjobPesronelID, int? StatusConfirmationID)> Confirmations
    {
        get
        {
            yield return (UjobPesronel01, StatusConfirmation01);
            yield return (UjobPesronel02, StatusConfirmation02);
            yield return (UjobPesronel03, StatusConfirmation03);
            yield return (UjobPesronel04, StatusConfirmation04);
            yield return (UjobPesronel05, StatusConfirmation05);
            yield return (UjobPesronel06, StatusConfirmation06);
            yield return (UjobPesronel07, StatusConfirmation07);
            yield return (UjobPesronel08, StatusConfirmation08);
            yield return (UjobPesronel09, StatusConfirmation09);
            yield return (UjobPesronel10, StatusConfirmation10);
            yield return (UjobPesronel11, StatusConfirmation11);
            yield return (UjobPesronel12, StatusConfirmation12);
        }
    }

    // ======= بقیه فیلدها بدون تغییر =======
    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

    public string? NOTAMCHECKETitle01 { get; set; }
    public string? NOTAMCHECKETitle02 { get; set; }
    public string? NOTAMCHECKETitle03 { get; set; }

    public bool? IsHaveJob { get; set; }

    public string? FlightEvidence01ID { get; set; }
    [ForeignKey("FlightEvidence01ID")]
    public virtual FlightEvidence01? ooRateFlight { get; set; }

    public string? StandCheckWritten01ID { get; set; }
    [ForeignKey("StandCheckWritten01ID")]
    public virtual StandCheckWritten01? ooStandCheck { get; set; }

    public string? HealthEvidence01ID { get; set; }
    [ForeignKey("HealthEvidence01ID")]
    public virtual HealthEvidence01? oo_HealthEvidence01 { get; set; }

    public string? NoNoticeEvidence01ID { get; set; }
    [ForeignKey("NoNoticeEvidence01ID")]
    public virtual NoNoticeEvidence01? oo_NoNoticeEvidence01 { get; set; }

    public string? EnglishExamEvidence01ID { get; set; }
    [ForeignKey("EnglishExamEvidence01ID")]
    public virtual EnglishExamEvidence01? oo_EnglishExamEvidence01 { get; set; }

    public string? LastfltDateFilnal01 { get; set; }

    [NotMapped]
    public string? DateHealthEvidence01ID => "000dc";
}
