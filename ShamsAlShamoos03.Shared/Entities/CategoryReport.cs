using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CategoryReport
{
    [Key]
    public int CategoryReportId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Section_01 { get; set; }
    public string Section_02 { get; set; }
    public string Seed_01 { get; set; }
    public string Seed_02 { get; set; }

    public int CategoryReportSubId { get; set; }
    [ForeignKey("CategoryReportSubId")]
    public virtual CategoryReportSub CategoryReportSub { get; set; }
}
