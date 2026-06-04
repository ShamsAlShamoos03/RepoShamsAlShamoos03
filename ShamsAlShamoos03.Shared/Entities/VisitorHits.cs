using System.ComponentModel.DataAnnotations;


public class VisitorHits
{
    [Key]
    public int id { get; set; }

    public string IpAddress { get; set; }

    public DateTime DateTime { get; set; }

    public int VisitHit { get; set; }
}
