using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352PlanEvidence01 : BaseDaily1352PlanEvidenceEntity
{
    [Key]
    public string? Daily1352PlanEvidence01ID { get; set; }

    public string? Daily1352ActivityEvidence01ID { get; set; }

    [ForeignKey(nameof(Daily1352ActivityEvidence01ID))]
    public virtual Daily1352ActivityEvidence01? oo_Daily1352ActivityEvidence01ID { get; set; }
}
