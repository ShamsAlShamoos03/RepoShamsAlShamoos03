using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CategoryImagesList
{
    [Key]
    public int CategoryImagesId { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime NewsDate { get; set; }
    public DateTime NewsTime { get; set; }
    public string NewsDateSham { get; set; }
    public string DateTimestring { get; set; }

    public int CategorySubImagesId { get; set; }
    [ForeignKey("CategorySubImagesId")]
    public virtual CategorySubImagesList CategorySubImagesList { get; set; }

    public virtual IList<ImagesListCategoryImagesList> ImagesListCategoryImagesLists { get; set; }
}
