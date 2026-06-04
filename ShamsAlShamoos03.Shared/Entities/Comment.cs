using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Comment
{
    [Key]
    public int Id { get; set; }

    public int NewsId { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string Message { get; set; }

    public string IP { get; set; }

    public DateTime commentDate { get; set; }

    public DateTime commentTime { get; set; }

    public int LikeCount { get; set; }
    public int DisLikeCount { get; set; }
    public bool status { get; set; }

    public int ReplyID { get; set; }
    [ForeignKey("NewsId")]
    public virtual News TblNews { get; set; }
}
