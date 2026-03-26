namespace BlazingPizza.Data;

public class OrderWithStatus
{
    public Order Order { get; set; } = default!;
    
    public string StatusText { get; set; } = string.Empty;

    public static OrderWithStatus FromOrder(Order order)
    {
        // To simulate order status, use random status based on order time
        string[] statuses = { "Preparing", "Out for delivery", "Delivered" };
        var random = new Random(order.OrderId); // Use OrderId as seed for consistent status
        
        var status = order.CreatedTime.AddMinutes(10) < DateTime.Now
            ? statuses[random.Next(statuses.Length)]
            : "Preparing";
            
        return new OrderWithStatus
        {
            Order = order,
            StatusText = status
        };
    }
}