using System.ComponentModel.DataAnnotations;


public class Quiz
{
    [Key]

    public int QuizId { get; set; }
    public string QuizName { get; set; }

    public virtual List<Question02> Questions02 { get; set; }
}

