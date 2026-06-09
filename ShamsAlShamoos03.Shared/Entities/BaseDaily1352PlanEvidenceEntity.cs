using System.ComponentModel.DataAnnotations.Schema;

public abstract class BaseDaily1352PlanEvidenceEntity : BaseApprovalNavigationEntity
{
    public string? PersonalCorrespondence01ID { get; set; }
    [ForeignKey(nameof(PersonalCorrespondence01ID))]
    public virtual PersonalCorrespondence01? oo_PersonalCorrespondence01ID { get; set; }

    public string? HelicopterTailEvidence01 { get; set; }
    [ForeignKey(nameof(HelicopterTailEvidence01))]
    public virtual HelicopterTailEvidence01? oo_HelicopterTailEvidence01 { get; set; }

    public string? MelliCode { get; set; }
    [ForeignKey(nameof(MelliCode))]
    public virtual TblMaster? oo_CrewDailyPesronel { get; set; }

    public int? StatAmar01 { get; set; }
    [ForeignKey(nameof(StatAmar01))]
    public virtual CategoryGeneral? oo_StatAmar01 { get; set; }

    public int? DesAmar01 { get; set; }
    [ForeignKey(nameof(DesAmar01))]
    public virtual CategoryGeneral? oo_DesAmar01 { get; set; }

    public string? DateDesAmar01 { get; set; }
    [ForeignKey(nameof(DateDesAmar01))]
    public virtual DateProperty01? oo_DateDesAmar01 { get; set; }

    public string? DateDesAmar02 { get; set; }
    [ForeignKey(nameof(DateDesAmar02))]
    public virtual DateProperty01? oo_DateDesAmar02 { get; set; }

    public string? DUS_COD01 { get; set; }
    [ForeignKey(nameof(DUS_COD01))]
    public virtual TblLuLookup? ooDUSCOD01 { get; set; }

    public int? UnitID01 { get; set; }
    [ForeignKey(nameof(UnitID01))]
    public virtual CategoryGeneral? oo_UnitID01 { get; set; }

    public int? UitIDGaurd01 { get; set; }
    [ForeignKey(nameof(UitIDGaurd01))]
    public virtual CategoryGeneral? oo_tblCategoryGeneralUitGaurd { get; set; }

    public string? DRJ_COD { get; set; }
    [ForeignKey(nameof(DRJ_COD))]
    public virtual TblLuLookup? ooDRJCOD { get; set; }

    public int? Sortable01Id { get; set; }
    [ForeignKey(nameof(Sortable01Id))]
    public virtual Sortable01? Sortable01 { get; set; }

    public string? NOTAMCHECKETitle01 { get; set; }
    public string? NOTAMCHECKETitle02 { get; set; }
    public string? NOTAMCHECKETitle03 { get; set; }

    public DateTime? TimeSignatureOREditYagen01 { get; set; }

    [NotMapped]
    public DateTime? newTimeSignatureOREditYagen01 =>
        TimeSignatureOREditYagen01?.AddHours(-1);

    public bool? IsHaveJob { get; set; }
}
