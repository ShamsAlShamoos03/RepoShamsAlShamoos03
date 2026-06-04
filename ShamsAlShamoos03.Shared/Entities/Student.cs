public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public virtual IList<StudentCourse> StudentCourses { get; set; }
}
