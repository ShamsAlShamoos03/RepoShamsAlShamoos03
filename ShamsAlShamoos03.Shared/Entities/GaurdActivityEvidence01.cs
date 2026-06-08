using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class GaurdActivityEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? GaurdActivityEvidence01ID { get; set; }

    public string? RegisterPesronel01 { get; set; }
    [ForeignKey("RegisterPesronel01")]
    public virtual UjobPesronel01 oo_RegisterPesronel01 { get; set; }

    public int? UnitID01 { get; set; }
    [ForeignKey("UnitID01")]
    public virtual CategoryGeneral? oo_UnitID01 { get; set; }

    public int? PropertyDay01ID { get; set; }
    [ForeignKey("PropertyDay01ID")]
    public virtual CategoryGeneral? oo_PropertyDay01ID { get; set; }

    public string? PlanUjobPesronel01 { get; set; }
    [ForeignKey("PlanUjobPesronel01")]
    public virtual UjobPesronel01 oo_PlanUjobPesronel01 { get; set; }

    public int? PlanStatusConfirmation01 { get; set; }
    [ForeignKey("PlanStatusConfirmation01")]
    public virtual CategoryGeneral oo_PlanStatusConfirmation01 { get; set; }

    public int? FLTAREANOTAMCHECK { get; set; }
    [ForeignKey("FLTAREANOTAMCHECK")]
    public virtual CategoryGeneral oo_TFLTAREANOTAMCHECK { get; set; }

    public int? StatusGaurdActivityEvidence01 { get; set; }
    [ForeignKey("StatusGaurdActivityEvidence01")]
    public virtual CategoryGeneral oo_StatusGaurdActivityEvidence01 { get; set; }

    public string? FromDateGaurdActivityEvidence01Title { get; set; }
    [ForeignKey("FromDateGaurdActivityEvidence01Title")]
    public virtual DateProperty01 oo_FromDateGaurdActivityEvidence01Title { get; set; }

    public string? ToDateGaurdActivityEvidence01Title { get; set; }

    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

    public string? NOTAMCHECKETitle01 { get; set; }
    public string? NOTAMCHECKETitle02 { get; set; }
    public string? NOTAMCHECKETitle03 { get; set; }

    public bool? IsHaveJob { get; set; }
}
