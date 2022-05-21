using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services;
public class PizzaService
{
    //this makes a new list that is to be filled with pizza objects
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;
    //This constructor puts two new pizza objects in the pizzalist
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian", Price=20.00M, Size=PizzaSize.    Large, IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", Price=15.00M, Size=PizzaSize.Small,     IsGlutenFree = true }
        };
    }

    //this function returns all the objects in in the pizzalist
    public static List<Pizza> GetAll() => Pizzas;

    //This function returns a spesiffic pizza element and it if cant find it it retruns som default value
    public static Pizza? Get(int Id ) => Pizzas.FirstOrDefault( p => p.Id == Id);

    //This function increases the id value of the pizza input and thjen adds it to the pizzas list
    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    //This function deletes the pizza with a given id, if the id is not found it does nothing
    public static void Delete(int Id)
    {
        var pizza = Get(Id);
        if(pizza is null) { return; }
        Pizzas.Remove(pizza);
    }

    //Dont know what this does
    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if(index == -1) { return; }
        Pizzas[index] = pizza;
    }
}
