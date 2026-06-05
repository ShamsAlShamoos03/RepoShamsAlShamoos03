using System.ComponentModel.DataAnnotations;

public class Sortable02
{
    [Key]
    public int Sortable01Id { get; set; }
    public int Idsort { get; set; }
    public string Description { get; set; }
}
