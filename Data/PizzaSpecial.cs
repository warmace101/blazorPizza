namespace BlazingPizza.Data;

public class PizzaSpecial
{
    public int Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    public decimal BasePrice { get; set; }
    
    public string ImageUrl { get; set; } = string.Empty;

    public string GetFormattedBasePrice()
    {
        return BasePrice.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
    }
}