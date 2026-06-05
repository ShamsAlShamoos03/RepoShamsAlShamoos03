using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PersonnelVazife01
{
    [Key]
    public int VazifeID { get; set; }

    public int RankID { get; set; }
    [ForeignKey("RankID")]
    public virtual CategoryGeneral? tblCategoryGeneralRank { get; set; }

    public int RastehID { get; set; }
    [ForeignKey("RastehID")]
    public virtual CategoryGeneral? tblCategoryGeneralRasteh { get; set; }

    public string Fname { get; set; }

    public string Lname { get; set; }
    public string Fathername { get; set; }
    public string PersonelCode { get; set; }

    public DateTime DispatchDate { get; set; }

    public string DispatchDateSham { get; set; }
    public DateTime BirthdayDate { get; set; }
    public string BirthdayDateSham { get; set; }
    public string NationalCode { get; set; }

    public int UitID { get; set; }
    [ForeignKey("UitID")]
    public virtual CategoryGeneral? tblCategoryGeneralUit { get; set; }

    public int HealthID { get; set; }
    [ForeignKey("HealthID")]
    public virtual CategoryGeneral? tblCategoryGeneralHealth { get; set; }

    public int MariageID { get; set; }
    [ForeignKey("MariageID")]
    public virtual CategoryGeneral? tblCategoryGeneralMariage { get; set; }

    public int NoChild { get; set; }

    public int StatusID { get; set; }
    [ForeignKey("StatusID")]
    public virtual CategoryGeneral? tblCategoryGeneralStatus { get; set; }

    public int BloodtypeID { get; set; }
    [ForeignKey("BloodtypeID")]
    public virtual CategoryGeneral? tblCategoryGeneralBlood { get; set; }

    public int DegreeeducationID { get; set; }
    [ForeignKey("DegreeeducationID")]
    public virtual CategoryGeneral? tblCategoryGeneralEducation { get; set; }

    public int FieldeducationID { get; set; }
    [ForeignKey("FieldeducationID")]
    public virtual CategoryGeneral? tblCategoryGeneralFieldedu { get; set; }

    public int ReligionID { get; set; }
    [ForeignKey("ReligionID")]
    public virtual CategoryGeneral? tblCategoryGeneralReligion { get; set; }

    public int CultID { get; set; }
    [ForeignKey("CultID")]
    public virtual CategoryGeneral? tblCategoryGeneralCult { get; set; }

    public int CityID { get; set; }
    [ForeignKey("CityID")]
    public virtual CategoryGeneral? tblCategoryGeneralCity { get; set; }

    public string Adress { get; set; }
    public string Mobile { get; set; }
    public string Phone { get; set; }

    public string PersonelImage { get; set; }
    public string EvidencelImage01 { get; set; }
    public string EvidencelImage02 { get; set; }
    public string EvidencelImage03 { get; set; }
    public string EvidencelImage04 { get; set; }

    public string Title01 { get; set; }
    public string Title02 { get; set; }
    public string Title03 { get; set; }
    public string Title04 { get; set; }
    public string Title05 { get; set; }
    public string Title06 { get; set; }
    public string Title07 { get; set; }
    public string Title08 { get; set; }

    public virtual IList<GuardboardVPG> TBL_GuardboardVPG { get; set; }
}
