using System.ComponentModel.DataAnnotations;

public class TblLookupsData
{
    [Key]

    public string ID { get; set; }
    //[Key]

    public string? type { get; set; }
    public string? title { get; set; }
    public int? AlphabeticSort { get; set; }
    public string? Cod_h { get; set; }
}
