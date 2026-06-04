using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



public class CategorySub
{
    [Key]
    public int CategrySubId { get; set; }
    public string TitleS { get; set; }
    public string DescriptionS { get; set; }
    public string Section_S01 { get; set; }
    public string Section_S02 { get; set; }
    public string Seed_S01 { get; set; }
    public string Seed_S02 { get; set; }
    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]

    public virtual Sortable01 Sortable01 { get; set; }
    public virtual IList<UsersCategorySub> UsersCategorySubs { get; set; }

    //public int CategoryID { get; set; }
    //[ForeignKey("CategoryID")]

    //public virtual Category Category { get; set; }

    //public virtual ICollection<NewsCategory01> NewsCategory01 { get; set; }
    //public IList<NewsCategory> NewsCategorys { get; set; }
}

