using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352INSPPlanEvidence01 : BaseDaily1352EvidenceEntity
{
    [Key]
    public string? Daily1352INSPPlanEvidence01ID { get; set; }

    /// <summary>
    ///شماره و مدل بالگرد 
    /// </summary>
    public string? HelicopterTailEvidence01 { get; set; }
    [ForeignKey("HelicopterTailEvidence01")]
    public virtual HelicopterTailEvidence01 oo_HelicopterTailEvidence01 { get; set; }

    /// <summary>
    ///وضعیت آمار روزانه 
    /// </summary>
    public string? INSPEDID01 { get; set; }
    [ForeignKey("INSPEDID01")]
    public virtual Daily1352INSPListPlanEvidence01 oo_INSPEDID01 { get; set; }

}
