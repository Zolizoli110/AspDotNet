using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class PriceModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    private int _id;
    
    [Required]
    private string _name;
    
    [Required]
    private int _price;

    public PriceModel(string name, int price)
    {
        _name = name;
        _price = price;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Price
    {
        get => _price;
        set => _price = value;
    }
}