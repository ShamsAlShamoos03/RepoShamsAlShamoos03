using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352INSPNextDuePlanEvidence01
    : BaseDaily1352EvidenceEntity
{
    [Key]
    public string? Daily1352INSPNextDuePlanEvidence01ID { get; set; }

    public string? Daily1352INSPPlanEvidence01ID { get; set; }

    [ForeignKey(nameof(Daily1352INSPPlanEvidence01ID))]
    public virtual Daily1352INSPPlanEvidence01? oo_Daily1352INSPPlanEvidence01 { get; set; }

    public string? JobStart01 { get; set; }
    public string? JobEnd01 { get; set; }
    public string? NextDue { get; set; }
}
