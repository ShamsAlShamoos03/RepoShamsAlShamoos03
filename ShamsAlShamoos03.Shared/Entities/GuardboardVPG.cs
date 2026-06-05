using System.ComponentModel.DataAnnotations;

public class GuardboardVPG
{
    [Key]
    public string GuardboardVPGID { get; set; }

    public int PropertyDayID { get; set; }
    public virtual PropertyDay TBL_date { get; set; }

    public int GaurdPostID { get; set; }
    public virtual GaurdPost TBL_GaurdPost { get; set; }

    public int VazifeID { get; set; }
    public virtual PersonnelVazife01 TBL_Vazife { get; set; }
}