
using System.ComponentModel.DataAnnotations.Schema;

namespace ShamsAlShamoos03.Shared.Entities;

public abstract class BaseApprovalEvidenceEntity
{
    // Sort
    public int? Sortable01Id { get; set; }

    [ForeignKey(nameof(Sortable01Id))]
    public virtual Sortable01? Sortable01 { get; set; }

    // Common fields
    public bool? IsHaveJob { get; set; }
    public string? MelliCode { get; set; }

    // NOTAM
    public string? NOTAMCHECKETitle01 { get; set; }
    public string? NOTAMCHECKETitle02 { get; set; }
    public string? NOTAMCHECKETitle03 { get; set; }

    // Personnel approvals
    public string? UjobPesronel01 { get; set; }
    public string? UjobPesronel02 { get; set; }
    public string? UjobPesronel03 { get; set; }
    public string? UjobPesronel04 { get; set; }
    public string? UjobPesronel05 { get; set; }
    public string? UjobPesronel06 { get; set; }
    public string? UjobPesronel07 { get; set; }
    public string? UjobPesronel08 { get; set; }
    public string? UjobPesronel09 { get; set; }
    public string? UjobPesronel10 { get; set; }
    public string? UjobPesronel11 { get; set; }
    public string? UjobPesronel12 { get; set; }

    // Status confirmations
    public int? StatusConfirmation01 { get; set; }
    public int? StatusConfirmation02 { get; set; }
    public int? StatusConfirmation03 { get; set; }
    public int? StatusConfirmation04 { get; set; }
    public int? StatusConfirmation05 { get; set; }
    public int? StatusConfirmation06 { get; set; }
    public int? StatusConfirmation07 { get; set; }
    public int? StatusConfirmation08 { get; set; }
    public int? StatusConfirmation09 { get; set; }
    public int? StatusConfirmation10 { get; set; }
    public int? StatusConfirmation11 { get; set; }
    public int? StatusConfirmation12 { get; set; }
}
