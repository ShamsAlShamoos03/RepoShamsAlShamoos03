using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class EvidencelImage
{
    [Key]
    public int EvidencelImageID { get; set; }

    public int PropertyDayID { get; set; }
    [ForeignKey("PropertyDayID")]
    public virtual PropertyDay? tblTypeday { get; set; }

    public string EvidencelImage01 { get; set; }
    public string NameEvidence01 { get; set; }
}
