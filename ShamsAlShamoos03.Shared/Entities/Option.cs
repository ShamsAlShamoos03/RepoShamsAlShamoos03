using System.ComponentModel.DataAnnotations.Schema;


public class Option
{
    public int Id { get; set; }
    public string Text { get; set; }
    public bool IsCorrect { get; set; }

    // کلید خارجی برای ارتباط با سوال
    public int QuestionId { get; set; }

    [ForeignKey("QuestionId")]
    public virtual Question Question { get; set; }
}
