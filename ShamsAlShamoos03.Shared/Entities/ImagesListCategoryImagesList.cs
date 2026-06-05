public class ImagesListCategoryImagesList
{
    public int ImagesListId { get; set; }
    public virtual ImagesList ImagesList { get; set; }

    public int CategoryImagesId { get; set; }
    public virtual CategoryImagesList CategoryImagesList { get; set; }
}