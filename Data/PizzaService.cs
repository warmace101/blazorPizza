namespace BlazingPizza.Data;

public class PizzaService
{
    private readonly List<Pizza> _pizzas;

    public PizzaService()
    {
        // Simulate data that might come from a database
        _pizzas = new List<Pizza>
        {
            new Pizza 
            { 
                PizzaId = 1, 
                Name = "Margherita Classic", 
                Description = "Traditional Italian pizza with fresh tomatoes, mozzarella, and basil",
                Price = 14.99m, 
                Vegetarian = true, 
                Vegan = false,
                Category = "Classic",
                Rating = 5,
                ImageUrl = "/images/margherita.jpg",
                Ingredients = new List<string> { "Tomato Sauce", "Fresh Mozzarella", "Basil", "Olive Oil" }
            },
            new Pizza 
            { 
                PizzaId = 2, 
                Name = "Pepperoni Deluxe", 
                Description = "Loaded with premium pepperoni and extra cheese",
                Price = 16.99m, 
                Vegetarian = false, 
                Vegan = false,
                Category = "Classic",
                Rating = 4,
                ImageUrl = "/images/pepperoni.jpg",
                Ingredients = new List<string> { "Tomato Sauce", "Mozzarella", "Pepperoni" }
            },
            new Pizza 
            { 
                PizzaId = 3, 
                Name = "Meat Lovers Supreme", 
                Description = "For serious meat enthusiasts - pepperoni, sausage, ham, and bacon",
                Price = 21.99m, 
                Vegetarian = false, 
                Vegan = false,
                Category = "Meat",
                Rating = 5,
                ImageUrl = "/images/meatlover.jpg",
                Ingredients = new List<string> { "Tomato Sauce", "Mozzarella", "Pepperoni", "Italian Sausage", "Ham", "Bacon" }
            },
            new Pizza 
            { 
                PizzaId = 4, 
                Name = "Veggie Garden", 
                Description = "Fresh vegetables on a crispy crust - perfect for vegetarians",
                Price = 15.99m, 
                Vegetarian = true, 
                Vegan = false,
                Category = "Vegetarian",
                Rating = 4,
                IsAvailable = false, // Simulate some items being out of stock
                ImageUrl = "/images/veggie.jpg",
                Ingredients = new List<string> { "Tomato Sauce", "Mozzarella", "Mushrooms", "Bell Peppers", "Red Onion", "Olives" }
            },
            new Pizza 
            { 
                PizzaId = 5, 
                Name = "Vegan Delight", 
                Description = "100% plant-based with cashew cheese and roasted vegetables",
                Price = 18.99m, 
                Vegetarian = true, 
                Vegan = true,
                Category = "Vegan",
                Rating = 4,
                ImageUrl = "/images/vegan.jpg",
                Ingredients = new List<string> { "Tomato Sauce", "Cashew Cheese", "Roasted Peppers", "Mushrooms", "Spinach" }
            },
            new Pizza 
            { 
                PizzaId = 6, 
                Name = "Truffle Mastery", 
                Description = "Luxurious truffle oil with wild mushrooms and arugula",
                Price = 26.99m, 
                Vegetarian = true, 
                Vegan = false,
                Category = "Gourmet",
                Rating = 5,
                ImageUrl = "/images/truffle.jpg",
                Ingredients = new List<string> { "White Sauce", "Mozzarella", "Wild Mushrooms", "Truffle Oil", "Arugula", "Parmesan" }
            },
            new Pizza 
            { 
                PizzaId = 7, 
                Name = "Hawaiian Paradise", 
                Description = "Tropical twist with ham and pineapple - love it or hate it!",
                Price = 17.99m, 
                Vegetarian = false, 
                Vegan = false,
                Category = "Classic",
                Rating = 3, // Controversial rating for Hawaiian pizza!
                ImageUrl = "/images/hawaiian.jpg",
                Ingredients = new List<string> { "Tomato Sauce", "Mozzarella", "Ham", "Pineapple" }
            },
            new Pizza 
            { 
                PizzaId = 8, 
                Name = "BBQ Chicken Ranch", 
                Description = "Grilled chicken with BBQ sauce and ranch dressing",
                Price = 19.99m, 
                Vegetarian = false, 
                Vegan = false,
                Category = "Gourmet",
                Rating = 4,
                ImageUrl = "/images/bbqchicken.jpg",
                Ingredients = new List<string> { "BBQ Sauce", "Mozzarella", "Grilled Chicken", "Red Onion", "Ranch Dressing" }
            }
        };
    }

    /// <summary>
    /// Gets all available pizzas asynchronously
    /// </summary>
    public async Task<Pizza[]> GetPizzasAsync()
    {
        // Simulate database call delay
        await Task.Delay(1500);
        
        return _pizzas.ToArray();
    }

    /// <summary>
    /// Gets pizzas filtered by category
    /// </summary>
    public async Task<Pizza[]> GetPizzasByCategoryAsync(string category)
    {
        // Simulate database call delay
        await Task.Delay(800);
        
        if (string.IsNullOrEmpty(category))
            return _pizzas.ToArray();
            
        return _pizzas.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToArray();
    }

    /// <summary>
    /// Gets only vegetarian pizzas
    /// </summary>
    public async Task<Pizza[]> GetVegetarianPizzasAsync()
    {
        await Task.Delay(600);
        return _pizzas.Where(p => p.Vegetarian).ToArray();
    }

    /// <summary>
    /// Gets only vegan pizzas
    /// </summary>
    public async Task<Pizza[]> GetVeganPizzasAsync()
    {
        await Task.Delay(600);
        return _pizzas.Where(p => p.Vegan).ToArray();
    }

    /// <summary>
    /// Gets pizzas within a price range
    /// </summary>
    public async Task<Pizza[]> GetPizzasByPriceRangeAsync(decimal minPrice, decimal maxPrice)
    {
        await Task.Delay(700);
        return _pizzas.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToArray();
    }

    /// <summary>
    /// Gets a specific pizza by ID
    /// </summary>
    public async Task<Pizza?> GetPizzaByIdAsync(int pizzaId)
    {
        await Task.Delay(400);
        return _pizzas.FirstOrDefault(p => p.PizzaId == pizzaId);
    }

    /// <summary>
    /// Gets pizzas sorted by rating (highest first)
    /// </summary>
    public async Task<Pizza[]> GetTopRatedPizzasAsync()
    {
        await Task.Delay(500);
        return _pizzas.Where(p => p.IsAvailable)
                     .OrderByDescending(p => p.Rating)
                     .ThenBy(p => p.Price)
                     .ToArray();
    }

    /// <summary>
    /// Search pizzas by name or description
    /// </summary>
    public async Task<Pizza[]> SearchPizzasAsync(string searchTerm)
    {
        await Task.Delay(900);
        
        if (string.IsNullOrWhiteSpace(searchTerm))
            return _pizzas.ToArray();
            
        return _pizzas.Where(p => 
            p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
            p.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
            p.Ingredients.Any(i => i.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
        ).ToArray();
    }

    /// <summary>
    /// Gets available categories
    /// </summary>
    public async Task<string[]> GetCategoriesAsync()
    {
        await Task.Delay(200);
        return _pizzas.Select(p => p.Category).Distinct().OrderBy(c => c).ToArray();
    }

    /// <summary>
    /// Simulates updating pizza availability
    /// </summary>
    public async Task<bool> UpdatePizzaAvailabilityAsync(int pizzaId, bool isAvailable)
    {
        await Task.Delay(300);
        
        var pizza = _pizzas.FirstOrDefault(p => p.PizzaId == pizzaId);
        if (pizza != null)
        {
            pizza.IsAvailable = isAvailable;
            return true;
        }
        return false;
    }
}