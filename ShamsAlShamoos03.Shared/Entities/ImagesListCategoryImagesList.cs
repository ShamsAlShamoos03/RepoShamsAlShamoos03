
public class ImagesListCategoryImagesList
{
    //public int NewsId { get; set; }
    //public virtual News News { get; set; }
    //public int CategryId { get; set; }
    //public virtual Category Category { get; set; }

    //public int StudentId { get; set; }
    //public Student Student { get; set; }

    //public int CourseId { get; set; }
    //public Course Course { get; set; }

    //[Key]
    public int ImagesListId { get; set; }
    public virtual ImagesList ImagesList { get; set; }

    public int CategoryImagesId { get; set; }
    public virtual CategoryImagesList CategoryImagesList { get; set; }













}
