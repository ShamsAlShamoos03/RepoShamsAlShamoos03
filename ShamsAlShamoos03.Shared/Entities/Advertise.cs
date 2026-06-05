using System.ComponentModel.DataAnnotations;

public class Advertise
{
    [Key]
    public int AdId { get; set; }
    public string? gifPath { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public string Link { get; set; }
    public byte flag { get; set; }
    public byte Advlocation { get; set; }
}