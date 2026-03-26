namespace BlazingPizza.Data;

public class PizzaSalesState
{
    private int _pizzasSoldToday;
    private decimal _totalRevenue;
    private string _lastOrderedPizza = string.Empty;
    private DateTime _lastOrderTime = DateTime.Now;

    public int PizzasSoldToday 
    { 
        get => _pizzasSoldToday;
        set
        {
            _pizzasSoldToday = value;
            NotifyStateChanged();
        }
    }

    public decimal TotalRevenue 
    { 
        get => _totalRevenue;
        set
        {
            _totalRevenue = value;
            NotifyStateChanged();
        }
    }

    public string LastOrderedPizza 
    { 
        get => _lastOrderedPizza;
        set
        {
            _lastOrderedPizza = value;
            _lastOrderTime = DateTime.Now;
            NotifyStateChanged();
        }
    }

    public DateTime LastOrderTime => _lastOrderTime;

    public decimal AverageOrderValue => PizzasSoldToday > 0 ? TotalRevenue / PizzasSoldToday : 0;

    // Event to notify when state changes
    public event Action? OnStateChanged;

    private void NotifyStateChanged() => OnStateChanged?.Invoke();

    // Helper methods
    public void RecordSale(string pizzaName, decimal price)
    {
        PizzasSoldToday++;
        TotalRevenue += price;
        LastOrderedPizza = pizzaName;
    }

    public void ResetDailyStats()
    {
        _pizzasSoldToday = 0;
        _totalRevenue = 0;
        _lastOrderedPizza = string.Empty;
        _lastOrderTime = DateTime.Now;
        NotifyStateChanged();
    }

    public string GetSalesToday()
    {
        if (PizzasSoldToday == 0)
            return "No pizzas sold yet today 😢";
        
        return PizzasSoldToday == 1 
            ? "1 amazing pizza sold! 🍕" 
            : $"{PizzasSoldToday} delicious pizzas sold! 🍕🎉";
    }
}