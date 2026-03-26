namespace BlazingPizza.Data;

public class Order
{
    public int OrderId { get; set; }
    
    public DateTime CreatedTime { get; set; } = DateTime.Now;
    
    public List<OrderPizza> Pizzas { get; set; } = new List<OrderPizza>();
    
    public decimal GetTotalPrice()
    {
        return Pizzas.Sum(p => p.GetTotalPrice());
    }
    
    public string GetFormattedTotalPrice()
    {
        return GetTotalPrice().ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
    }
}