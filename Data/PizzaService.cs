namespace blazor_erp.Data;

using System.Threading.Tasks;

public class PizzaService
{
    public Task<PizzaEntity[]> GetPizzasAsync()
    {
            var pizzas = new[]
            {
                new PizzaEntity { Id = 1, Name = "Margherita", Price = 9.99m, Description = "Traditional Italian pizza with tomatoes and basil" },
                new PizzaEntity { Id = 2, Name = "Pepperoni", Price = 10.99m, Description = "Classic pepperoni pizza with spicy pepperoni" },
                new PizzaEntity { Id = 3, Name = "BBQ Chicken", Price = 11.99m, Description = "Pizza with BBQ sauce, chicken, and red onions" }
            };
            return Task.FromResult(pizzas);
    }
}


