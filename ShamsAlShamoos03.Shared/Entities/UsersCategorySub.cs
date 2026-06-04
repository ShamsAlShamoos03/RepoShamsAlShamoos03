using System.ComponentModel.DataAnnotations.Schema;

public class UsersCategorySub
{
    //[Key]
    //public int mID { get; set; }
    //public virtual News News { get; set; }
    //public int CategryId { get; set; }
    //public virtual Category Category { get; set; }

    //public int StudentId { get; set; }
    //public Student Student { get; set; }

    //public int CourseId { get; set; }
    //public Course Course { get; set; }

    //[Key]
    public int CategrySubId { get; set; }
    public virtual CategorySub CategorySub { get; set; }

    public string UserID { get; set; }
    public virtual ApplicationUsers ApplicationUsers { get; set; }





    public string sort01 { get; set; }
    public string sort02 { get; set; }

    public string des01 { get; set; }
    public string des02 { get; set; }



    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]

    public virtual Sortable01 Sortable01 { get; set; }






}
