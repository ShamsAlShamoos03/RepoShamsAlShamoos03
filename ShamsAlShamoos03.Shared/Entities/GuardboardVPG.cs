using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;


public class GuardboardVPG
{
    //public int NewsId { get; set; }
    //public virtual News News { get; set; }
    //public int CategryId { get; set; }
    //public virtual Category Category { get; set; }

    //public int StudentId { get; set; }
    //public Student Student { get; set; }

    //public int CourseId { get; set; }
    //public Course Course { get; set; }
    //p1.ID = GUID.NewGUID();
    [Key]
    public string GuardboardVPGID { get; set; }

    public int PropertyDayID { get; set; }
    public virtual PropertyDay TBL_date { get; set; }


    public int GaurdPostID { get; set; }
    public virtual GaurdPost TBL_GaurdPost { get; set; }


    public int VazifeID { get; set; }
    public virtual PersonnelVazife01 TBL_Vazife { get; set; }



    //public int UitID { get; set; } 
    //[ForeignKey("UitID")]
    //public virtual CategoryGeneral? TBL_Uit { get; set; }










}
