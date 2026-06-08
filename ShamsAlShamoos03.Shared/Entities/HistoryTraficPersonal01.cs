using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class HistoryTraficPersonal01 : BaseApprovalNavigationEntity
{
    /// <summary>
    ///  تاریخ شمسی
    /// </summary>
    [Key]
    //[StringLength(10, MinimumLength = 10, ErrorMessage = "HistoryTraficPersonal01ID must be 8 characters")]
    public string? HistoryTraficPersonal01ID { get; set; }



    public string? HistoryVazifehDastoorPersonal01ID { get; set; }
    [ForeignKey("HistoryVazifehDastoorPersonal01ID")]
    public virtual HistoryVazifehDastoorPersonal01 oo_HistoryVazifehDastoorPersonal01ID { get; set; }



    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate01 { get; set; }
    [ForeignKey("VarDate01")]
    public virtual DateProperty01 oo_VarDate01 { get; set; }


    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate02 { get; set; }
    [ForeignKey("VarDate02")]
    public virtual DateProperty01 oo_VarDate02 { get; set; }


    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate03 { get; set; }
    [ForeignKey("VarDate03")]
    public virtual DateProperty01 oo_VarDate03 { get; set; }


    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate04 { get; set; }
    [ForeignKey("VarDate04")]
    public virtual DateProperty01 oo_VarDate04 { get; set; }


    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate05 { get; set; }
    [ForeignKey("VarDate05")]
    public virtual DateProperty01 oo_VarDate05 { get; set; }


    /// <summary>
    //تاریخ
    /// </summary>
    public string? VarDate06 { get; set; }
    [ForeignKey("VarDate06")]
    public virtual DateProperty01 oo_VarDate06 { get; set; }





    /// <summary>
    /// یگان
    /// </summary>
    public int? UnitID01 { get; set; }
    [ForeignKey("UnitID01")]
    public virtual CategoryGeneral? oo_UnitID01 { get; set; }





    /// <summary>
    //شماره نامه
    /// </summary>
    public string? DocumentNO01 { get; set; }

    /// <summary>
    //متن نامه
    /// </summary>
    public string? strTextContent01 { get; set; }

    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext01 { get; set; }
    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext02 { get; set; }
    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext03 { get; set; }
    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext04 { get; set; }
    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext05 { get; set; }
    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext06 { get; set; }



    /// <summary>
    ///  درجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster oo_CrewDailyPesronel { get; set; }





    /// <summary>
    ///نوع نامه  
    /// </summary>
    public int? TypeLetter01 { get; set; }
    [ForeignKey("TypeLetter01")]
    public virtual CategoryGeneral oo_TypeLetter01 { get; set; }

    public DateTime? TimeAddOREditYagen01 { get; set; }






 







}
