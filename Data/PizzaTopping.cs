namespace BlazingPizza.Data;

public class PizzaTopping
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Ingredients { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsSpicy { get; set; }
    public bool IsVegetarian { get; set; } = true;
    
    // For Entity Framework relationships (optional)
    public int? PizzaId { get; set; }
    public int? ToppingId { get; set; }
    public Topping? Topping { get; set; }
}