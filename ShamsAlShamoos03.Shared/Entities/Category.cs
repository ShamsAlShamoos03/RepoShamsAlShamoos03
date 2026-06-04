using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category
{
    [Key]
    public int CategryId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Section_01 { get; set; }
    public string Section_02 { get; set; }
    public string Seed_01 { get; set; }
    public string Seed_02 { get; set; }


    public int CategrySubId { get; set; }
    [ForeignKey("CategrySubId")]

    public virtual CategorySub CategorySub { get; set; }


    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]

    public virtual Sortable01 Sortable01 { get; set; }



    //public virtual ICollection<NewsCategory01> NewsCategory01 { get; set; }
    public virtual IList<NewsCategory> NewsCategorys { get; set; }
    public virtual IList<UsersCategory> UsersCategorys { get; set; }


}

