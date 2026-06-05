using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class GaurdPost
{
    [Key]
    public int GaurdPostID { get; set; }

    public int GaurdPostNameID { get; set; }
    [ForeignKey("GaurdPostNameID")]
    public virtual CategoryGeneral? tblCategoryGeneralPostName { get; set; }

    public int PasID { get; set; }
    [ForeignKey("PasID")]
    public virtual CategoryGeneral? tblCategoryGeneralPas { get; set; }

    public int GaurdPostTypeID { get; set; }
    [ForeignKey("GaurdPostTypeID")]
    public virtual CategoryGeneral? tblCategoryGeneralType { get; set; }

    public int EquipID { get; set; }
    [ForeignKey("EquipID")]
    public virtual CategoryGeneral? tblCategoryGeneralEquip { get; set; }

    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

    public int Prop01ID { get; set; }
    [ForeignKey("Prop01ID")]
    public virtual CategoryGeneral? tblCategoryGeneralProp01 { get; set; }

    public int Prop02ID { get; set; }
    [ForeignKey("Prop02ID")]
    public virtual CategoryGeneral? tblCategoryGeneralProp02 { get; set; }

    public int Prop03ID { get; set; }
    [ForeignKey("Prop03ID")]
    public virtual CategoryGeneral? tblCategoryGeneralProp03 { get; set; }

    public byte IsActive { get; set; }

    public virtual IList<GuardboardVPG> TBL_GuardboardVPG { get; set; }

    public int UitID { get; set; }
    [ForeignKey("UitID")]
    public virtual CategoryGeneral? TBL_Uit { get; set; }
}
