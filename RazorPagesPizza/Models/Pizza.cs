using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models;

public class Pizza
{
    public int Id { get; set; }


    //This indicates that the following value must have a value
    [Required]
    public string? Name { get; set; }
    public PizzaSize Size { get; set; }
    public bool IsGlutenFree { get; set; }

    //This says the value have to be in the given range
    [Range(0.01, 9999.99)]
    public decimal  Price { get; set; }
}

public enum PizzaSize { Small, Medium, Large}
