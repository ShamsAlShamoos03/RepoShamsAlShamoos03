
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class CategoryGeneralSub
{
    [Key]
    public int CategoryGeneralSubId { get; set; }
    public string TitleS { get; set; }
    public string DescriptionS { get; set; }


    public int Sortable01Id { get; set; } /*= 1;*/
    [ForeignKey("Sortable01Id")]

    public virtual Sortable02 Sortable02 { get; set; }

    public byte IsActive { get; set; } /*= 1;*/
    //public string Section_S01 { get; set; }
    //public string Section_S02 { get; set; }
    //public string Seed_S01 { get; set; }
    //public string Seed_S02 { get; set; }

    //public IList<UsersCategorySub> UsersCategorySubs { get; set; }

    //public int CategoryID { get; set; }
    //[ForeignKey("CategoryID")]

    //public virtual Category Category { get; set; }

    //public virtual ICollection<NewsCategory01> NewsCategory01 { get; set; }
    //public IList<NewsCategory> NewsCategorys { get; set; }
}

