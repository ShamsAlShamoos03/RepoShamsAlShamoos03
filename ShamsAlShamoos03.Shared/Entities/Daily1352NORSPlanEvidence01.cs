using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352NORSPlanEvidence01 : BaseDaily1352PlanEvidenceEntity
{
    [Key]
    public string? Daily1352NORSPlanEvidence01ID { get; set; }

    public string? Daily1352ActivityEvidence01ID { get; set; }

    [ForeignKey(nameof(Daily1352ActivityEvidence01ID))]
    public virtual Daily1352ActivityEvidence01? oo_Daily1352ActivityEvidence01ID { get; set; }

    public int? PARTNORSID01 { get; set; }

    [ForeignKey(nameof(PARTNORSID01))]
    public virtual CategoryGeneral? oo_PARTNORSID01 { get; set; }

    public int? PARTNONORSID01 { get; set; }

    [ForeignKey(nameof(PARTNONORSID01))]
    public virtual CategoryGeneral? oo_PARTNONORSID01 { get; set; }

    public string? DOCUMENTNO { get; set; }
    public string? QUANTITY { get; set; }

    public string? DATENORS { get; set; }

    [ForeignKey(nameof(DATENORS))]
    public virtual DateProperty01? oo_DATENORS { get; set; }

    public string? RegisterPesronel01 { get; set; }

    [ForeignKey(nameof(RegisterPesronel01))]
    public virtual UjobPesronel01? oo_RegisterPesronel01 { get; set; }

    public string? EditedPesronel01 { get; set; }

    [ForeignKey(nameof(EditedPesronel01))]
    public virtual UjobPesronel01? oo_EditedPesronel011 { get; set; }
}
