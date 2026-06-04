using System.ComponentModel.DataAnnotations;

public class JsTree01
{
    [Key]
    public string JobsID { get; set; }
    public string JobsName { get; set; }
    public string JobsLevel { get; set; }
}

