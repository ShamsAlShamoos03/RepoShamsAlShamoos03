using System.ComponentModel.DataAnnotations.Schema;

public abstract class BaseDaily1352EvidenceEntity : BaseApprovalNavigationEntity
{
    /// <summary>
    ///01 کد ملی ثبت کننده
    /// </summary>
    public string? RegisterPesronel01 { get; set; }

    [ForeignKey(nameof(RegisterPesronel01))]
    public virtual UjobPesronel01? oo_RegisterPesronel01 { get; set; }

    /// <summary>
    ///01 کد ملی ویرایش کننده
    /// </summary>
    public string? EditedPesronel01 { get; set; }

    [ForeignKey(nameof(EditedPesronel01))]
    public virtual UjobPesronel01? oo_EditedPesronel011 { get; set; }

    /// <summary>
    /// ترتیب
    /// </summary>
    public int? Sortable01Id { get; set; }

    [ForeignKey(nameof(Sortable01Id))]
    public virtual Sortable01? Sortable01 { get; set; }

    public string? NOTAMCHECKETitle01 { get; set; }
    public string? NOTAMCHECKETitle02 { get; set; }
    public string? NOTAMCHECKETitle03 { get; set; }

    public DateTime? TimeSignatureOREditYagen01 { get; set; }

    public bool? IsHaveJob { get; set; }
}
