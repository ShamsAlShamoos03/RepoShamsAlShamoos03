using System.ComponentModel.DataAnnotations;


public class TblUnitsInfo
{
    [Key]

    public string UnitCode { get; set; }
    public string? UnitTitle { get; set; }
    public int? ParentCode { get; set; }
    public string? ParentTitle { get; set; }
    public string? COD_NJA { get; set; }
    public string? TableNo { get; set; }
    public string? TableCaption { get; set; }
    public string? TableNoDate { get; set; }
    public string? OldtableNo { get; set; }
    public int? AreaDutyCode { get; set; }
    public string? AreaDutyCodeDate { get; set; }
    public int? OldareaDutyCode { get; set; }
    public int? CityCode { get; set; }
    public string? CityCodeDate { get; set; }
    public int? OldCityCode { get; set; }
    public int? SalaryUnitCode { get; set; }
    public int? EngineerPostUnitCode { get; set; }
    public int? UnitType { get; set; }
    public byte? IsNew { get; set; }
    public int? IsActive { get; set; }
    public string? ActivationDate { get; set; }
    public string? DeActivationDate { get; set; }
    public string? ChangeDate { get; set; }
    public int? OMD_YEG { get; set; }
    public string? OMD_NAME { get; set; }
    public string? YEG_MAD { get; set; }
    public string? SHO_RAD { get; set; }
    public double? RAD_DIF { get; set; }
    public int? MissionType { get; set; }
    public string? Serial_Yeg { get; set; }
    public byte? OwnerDastoor { get; set; }
}
