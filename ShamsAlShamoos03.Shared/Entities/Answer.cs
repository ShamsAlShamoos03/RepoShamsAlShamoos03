using System.ComponentModel.DataAnnotations;

public class Answer
{
    [Key]
    public int AnswerId { get; set; }
    public int QuestionId { get; set; }
    public int ChoiceId { get; set; }

    public string AnswerText { get; set; }

    public virtual Question02 Question02 { get; set; }
    public virtual Choice Choice { get; set; }
}
