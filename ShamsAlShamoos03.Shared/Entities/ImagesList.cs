using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ImagesList
{
    [Key]
    public int ImagesListId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Abstract { get; set; }
    public int VisitCount { get; set; }
    public DateTime ImagesListDate { get; set; }
    public string ImagesListDateSham { get; set; }
    public DateTime ImagesListTime { get; set; }

    public string? IndexImage { get; set; }
    public string IndexImage02 { get; set; }
    public byte PlaceImagesListID { get; set; }
    public byte ImagesListType { get; set; }

    public string MetaTag { get; set; }
    public string MetaDescription { get; set; }

    public int CategoryImagesId { get; set; }
    [ForeignKey("CategoryImagesId")]
    public virtual CategoryImagesList tblCategoryImagesList { get; set; }

    public virtual IList<ImagesListCategoryImagesList> ImagesListCategoryImagesLists { get; set; }
    public virtual IList<NewsImagesList> NewsImagesLists { get; set; }
}