using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class NewsModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    private int _id;

    [Column]
    private DateTimeOffset _published;
    
    [Required]
    private string _summary;

    [Required]
    private string _text;

    public NewsModel(string summary, string text)
    {
        _published = DateTimeOffset.Now;
        _summary = summary;
        _text = text;
    }
    
    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public DateTimeOffset Published
    {
        get => _published;
        set => _published = value;
    }

    public string Summary
    {
        get => _summary;
        set => _summary = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Text
    {
        get => _text;
        set => _text = value ?? throw new ArgumentNullException(nameof(value));
    }
}