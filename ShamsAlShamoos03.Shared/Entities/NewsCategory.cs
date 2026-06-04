using System.ComponentModel.DataAnnotations.Schema;



public class NewsCategory
{
    public int NewsId { get; set; }
    public virtual News News { get; set; }

    public int CategoryID { get; set; }
    public virtual Category Category { get; set; }


    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]

    public virtual Sortable01 Sortable01 { get; set; }

}
