using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class News
{
    [Key]
    public int NewsId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Abstract { get; set; }
    public int VisitCount { get; set; }
    public DateTime NewsDate { get; set; }
    public string NewsDateSham { get; set; }
    public DateTime NewsTime { get; set; }

    public string? IndexImage { get; set; }
    public string IndexImage02 { get; set; }
    public byte PlaceNewsID { get; set; }
    public byte NewsType { get; set; }
    public byte IsActive { get; set; }

    public string MetaTag { get; set; }
    public string MetaDescription { get; set; }

    public string UserID { get; set; }
    [ForeignKey("UserID")]
    public virtual ApplicationUsers Users { get; set; }

    public int CategoryID { get; set; }
    [ForeignKey("CategoryID")]
    public virtual Category tblCategory { get; set; }

    public virtual IList<NewsCategory> NewsCategorys { get; set; }

    public virtual IList<NewsImagesList> NewsImagesLists { get; set; }
}
