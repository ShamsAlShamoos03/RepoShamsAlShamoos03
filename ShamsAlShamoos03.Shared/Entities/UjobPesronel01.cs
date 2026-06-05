using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class UjobPesronel01
{
    [Key]
    public string UjobPesronel01ID { get; set; }

    public string UserID { get; set; }
    public virtual ApplicationUsers Users { get; set; }

    public string MelliCode { get; set; }
    public virtual TblMaster MelliCodeList { get; set; }

    public DateTime StartJobDate { get; set; }
    public DateTime EndJobDate { get; set; }
    public bool IsHaveJob { get; set; }

    public string StartJobDatestr { get; set; }
    public string EndJobDatestr { get; set; }

    public string des01 { get; set; }
    public string des02 { get; set; }

    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }
}