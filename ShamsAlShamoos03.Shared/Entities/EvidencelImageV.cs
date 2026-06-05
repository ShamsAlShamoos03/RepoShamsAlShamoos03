using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class EvidencelImageV
{
    [Key]
    public int EvidencelImageVID { get; set; }

    public int VazifeID { get; set; }
    [ForeignKey("VazifeID")]
    public virtual PersonnelVazife01? tblVazifeID { get; set; }

    public string EvidencelImageV01 { get; set; }
    public string NameEvidence01 { get; set; }
}