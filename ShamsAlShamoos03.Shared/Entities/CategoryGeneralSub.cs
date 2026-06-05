using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CategoryGeneralSub
{
    [Key]
    public int CategoryGeneralSubId { get; set; }
    public string TitleS { get; set; }
    public string DescriptionS { get; set; }

    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable02 Sortable02 { get; set; }

    public byte IsActive { get; set; }
}
