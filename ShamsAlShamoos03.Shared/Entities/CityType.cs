using System.ComponentModel.DataAnnotations;

public class CityType
{
    [Key]

    public string ID { get; set; }
    public string? TITLE { get; set; }
    public int? ALPHABETICSORT { get; set; }
    public string? Cod_h { get; set; }
}
