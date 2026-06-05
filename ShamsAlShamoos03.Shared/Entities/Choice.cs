public class Choice
{
    public int ChoiceId { get; set; }
    public string ChoiceText { get; set; }
    public int QuestionId { get; set; }

    public virtual Question02 Question02 { get; set; }
}
