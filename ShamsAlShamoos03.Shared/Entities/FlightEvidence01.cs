using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class FlightEvidence01
{
    [Key]
    public string? FlightEvidence01ID { get; set; }

    public int? Rate { get; set; }
    [ForeignKey("Rate")]
    public virtual CategoryGeneral Rate_CategoryGeneral { get; set; }

    public int? TypeAC { get; set; }
    [ForeignKey("TypeAC")]
    public virtual CategoryGeneral TypeAC_CategoryGeneral { get; set; }

    public int? EvidenceFlightTitle { get; set; }
    [ForeignKey("EvidenceFlightTitle")]
    public virtual CategoryGeneral EvidenceFlightTitle_CategoryGeneral { get; set; }

    public string? DateSrartEvidenceFlightTitle { get; set; }
    public string? DateEndEvidenceFlightTitle { get; set; }

    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster MelliCodeList0AA { get; set; }

    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

    public bool? IsHaveJob { get; set; }
}
