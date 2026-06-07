
using System.ComponentModel.DataAnnotations.Schema;

public abstract class BaseApprovalNavigationEntity
{
    public string? UjobPesronel01 { get; set; }
    public int? StatusConfirmation01 { get; set; }
    public string? UjobPesronel02 { get; set; }
    public int? StatusConfirmation02 { get; set; }
    public string? UjobPesronel03 { get; set; }
    public int? StatusConfirmation03 { get; set; }
    public string? UjobPesronel04 { get; set; }
    public int? StatusConfirmation04 { get; set; }
    public string? UjobPesronel05 { get; set; }
    public int? StatusConfirmation05 { get; set; }
    public string? UjobPesronel06 { get; set; }
    public int? StatusConfirmation06 { get; set; }
    public string? UjobPesronel07 { get; set; }
    public int? StatusConfirmation07 { get; set; }
    public string? UjobPesronel08 { get; set; }
    public int? StatusConfirmation08 { get; set; }
    public string? UjobPesronel09 { get; set; }
    public int? StatusConfirmation09 { get; set; }
    public string? UjobPesronel10 { get; set; }
    public int? StatusConfirmation10 { get; set; }
    public string? UjobPesronel11 { get; set; }
    public int? StatusConfirmation11 { get; set; }
    public string? UjobPesronel12 { get; set; }
    public int? StatusConfirmation12 { get; set; }

    [ForeignKey(nameof(UjobPesronel01))] public virtual UjobPesronel01? oo_UjobPesronel01 { get; set; }
    [ForeignKey(nameof(StatusConfirmation01))] public virtual CategoryGeneral? oo_StatusConfirmation01 { get; set; }
    [ForeignKey(nameof(UjobPesronel02))] public virtual UjobPesronel01? oo_UjobPesronel02 { get; set; }
    [ForeignKey(nameof(StatusConfirmation02))] public virtual CategoryGeneral? oo_StatusConfirmation02 { get; set; }
    [ForeignKey(nameof(UjobPesronel03))] public virtual UjobPesronel01? oo_UjobPesronel03 { get; set; }
    [ForeignKey(nameof(StatusConfirmation03))] public virtual CategoryGeneral? oo_StatusConfirmation03 { get; set; }
    [ForeignKey(nameof(UjobPesronel04))] public virtual UjobPesronel01? oo_UjobPesronel04 { get; set; }
    [ForeignKey(nameof(StatusConfirmation04))] public virtual CategoryGeneral? oo_StatusConfirmation04 { get; set; }
    [ForeignKey(nameof(UjobPesronel05))] public virtual UjobPesronel01? oo_UjobPesronel05 { get; set; }
    [ForeignKey(nameof(StatusConfirmation05))] public virtual CategoryGeneral? oo_StatusConfirmation05 { get; set; }
    [ForeignKey(nameof(UjobPesronel06))] public virtual UjobPesronel01? oo_UjobPesronel06 { get; set; }
    [ForeignKey(nameof(StatusConfirmation06))] public virtual CategoryGeneral? oo_StatusConfirmation06 { get; set; }
    [ForeignKey(nameof(UjobPesronel07))] public virtual UjobPesronel01? oo_UjobPesronel07 { get; set; }
    [ForeignKey(nameof(StatusConfirmation07))] public virtual CategoryGeneral? oo_StatusConfirmation07 { get; set; }
    [ForeignKey(nameof(UjobPesronel08))] public virtual UjobPesronel01? oo_UjobPesronel08 { get; set; }
    [ForeignKey(nameof(StatusConfirmation08))] public virtual CategoryGeneral? oo_StatusConfirmation08 { get; set; }
    [ForeignKey(nameof(UjobPesronel09))] public virtual UjobPesronel01? oo_UjobPesronel09 { get; set; }
    [ForeignKey(nameof(StatusConfirmation09))] public virtual CategoryGeneral? oo_StatusConfirmation09 { get; set; }
    [ForeignKey(nameof(UjobPesronel10))] public virtual UjobPesronel01? oo_UjobPesronel10 { get; set; }
    [ForeignKey(nameof(StatusConfirmation10))] public virtual CategoryGeneral? oo_StatusConfirmation10 { get; set; }
    [ForeignKey(nameof(UjobPesronel11))] public virtual UjobPesronel01? oo_UjobPesronel11 { get; set; }
    [ForeignKey(nameof(StatusConfirmation11))] public virtual CategoryGeneral? oo_StatusConfirmation11 { get; set; }
    [ForeignKey(nameof(UjobPesronel12))] public virtual UjobPesronel01? oo_UjobPesronel12 { get; set; }
    [ForeignKey(nameof(StatusConfirmation12))] public virtual CategoryGeneral? oo_StatusConfirmation12 { get; set; }
}
