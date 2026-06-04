using System.ComponentModel.DataAnnotations;


public class User02
{
    [Key]
    public int UserId { get; set; }
    public string Username { get; set; }
    public string FullName { get; set; }

    public string ProfilImage { get; set; }

}
