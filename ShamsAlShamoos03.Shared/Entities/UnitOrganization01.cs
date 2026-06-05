using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class UnitOrganization01
{
    /// <summary>
    ///  تاریخ شمسی
    /// </summary>
    [Key]
    public string? UnitOrganization01ID { get; set; }

    /// <summary>
    /// یگان
    /// </summary>
    public int? UitID01 { get; set; }
    [ForeignKey("UitID01")]
    public virtual CategoryGeneral? oo_tblCategoryGeneralUit { get; set; }

    public int? TblLuLookupSubbId { get; set; }
    [ForeignKey("TblLuLookupSubbId")]
    public virtual TblLuLookupSub TblLuLookupSub { get; set; }

    /// <summary>
    /// شماره پرونده بایگانی 01
    /// </summary>
    public string? NoFolder01 { get; set; }

    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }
}