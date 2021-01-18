using System.ComponentModel.DataAnnotations;

public class NewsItem
{
    [Key]
    public int NewsID { get; set; }
    public string Header { get; set; }
    public string Body { get; set; }
    public bool HasImage { get; set; }
}