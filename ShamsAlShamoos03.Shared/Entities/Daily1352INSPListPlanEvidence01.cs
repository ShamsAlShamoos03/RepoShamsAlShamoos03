using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352INSPListPlanEvidence01
    : BaseDaily1352EvidenceEntity
{
    [Key]
    public string? Daily1352INSPListPlanEvidence01ID { get; set; }

    public int? TypeHelicopter { get; set; }

    [ForeignKey(nameof(TypeHelicopter))]
    public virtual CategoryGeneral? oo_TypeHelicopter { get; set; }

    public string? ITEMTOBEINSPECTED { get; set; }
    public string? REFERENCE { get; set; }
    public string? FREQUENCY { get; set; }

    public int? FREQRANGE { get; set; }

    [ForeignKey(nameof(FREQRANGE))]
    public virtual CategoryGeneral? oo_FREQRANGE { get; set; }

    public string? FREQPERIOD { get; set; }
}
