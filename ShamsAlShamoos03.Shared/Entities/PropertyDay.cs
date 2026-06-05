using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PropertyDay
{
    [Key]
    public int PropertyDayID { get; set; }

    public DateTime DateDay { get; set; }

    public string DateDaySham { get; set; }

    public string DateDayWeek { get; set; }

    public int TypedayID { get; set; }
    [ForeignKey("TypedayID")]
    public virtual CategoryGeneral? tblTypeday { get; set; }

    public int IRcalID { get; set; }
    [ForeignKey("IRcalID")]
    public virtual CategoryGeneral? tblIRcal { get; set; }

    public int StatecalID { get; set; }
    [ForeignKey("StatecalID")]
    public virtual CategoryGeneral? tblStatecal { get; set; }

    public int Prop01ID { get; set; }
    [ForeignKey("Prop01ID")]
    public virtual CategoryGeneral? tblCategoryGeneralProp01 { get; set; }

    public int Prop02ID { get; set; }
    [ForeignKey("Prop02ID")]
    public virtual CategoryGeneral? tblCategoryGeneralProp02 { get; set; }

    public int Prop03ID { get; set; }
    [ForeignKey("Prop03ID")]
    public virtual CategoryGeneral? tblCategoryGeneralProp03 { get; set; }

    public virtual IList<GuardboardVPG> TBL_GuardboardVPG { get; set; }
}
