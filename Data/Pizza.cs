namespace BlazingPizza.Data;

public class Pizza
{
    public int PizzaId { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    public decimal Price { get; set; }
    
    public bool Vegetarian { get; set; }
    
    public bool Vegan { get; set; }
    
    // Additional properties for enhanced functionality
    public string ImageUrl { get; set; } = string.Empty;
    
    public string Category { get; set; } = string.Empty;
    
    public string Size { get; set; } = "Large";
    
    public int Rating { get; set; }
    
    public bool IsAvailable { get; set; } = true;
    
    public List<string> Ingredients { get; set; } = new();
    
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}