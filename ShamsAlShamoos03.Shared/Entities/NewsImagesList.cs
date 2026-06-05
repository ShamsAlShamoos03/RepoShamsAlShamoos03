using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class NewsImagesList
{
    [Key]
    public string NewsImagesID { get; set; }

    public int NewsId { get; set; }
    public virtual News News { get; set; }

    public int ImagesListId { get; set; }
    public virtual ImagesList ImagesList { get; set; }

    public string sort01 { get; set; }
    public string sort02 { get; set; }

    public string des01 { get; set; }
    public string des02 { get; set; }

    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }
}