namespace MyWebAPI.Services.PizzaService
{
    public class PizzaService : IPizzaService
    {
        private static List<Pizza> pizzas = new List<Pizza>
            {
                new Pizza { Id = 1, Topping = "Pepperoni", Cheese = "Mozzarella", Crust = "Plain", Size = "Large"},
                new Pizza { Id = 2, Topping = "Margherita", Cheese = "Cuattro Formaggio", Crust = "Wheat", Size = "Medium"},
                new Pizza { Id = 3, Topping = "Sausage", Cheese = "Gruyere", Crust = "Stuffed", Size = "Extra Large"}
            };

        public List<Pizza> GetAllPizza()
        {
            return pizzas;
        }
        public Pizza? GetOnePizza(int id)
        {
            var slice = pizzas.Find(x => x.Id == id);
            if (slice is null)
                return null;

            return slice;
        }
        public List<Pizza> AddPizza(Pizza slice)
        {
            pizzas.Add(slice);
            return pizzas;
        }

        public List<Pizza>? UpdatePizza(int id, Pizza request)
        {
            var slice = pizzas.Find(x => x.Id == id);
            if (slice is null)
                return null;

            slice.Topping = request.Topping;
            slice.Cheese = request.Cheese;
            slice.Crust = request.Crust;
            slice.Size = request.Size;

            return pizzas;
        }
        public List<Pizza>? DeletePizza(int id)
        {
            var slice = pizzas.Find(x => x.Id == id);
            if (slice is null)
                return null;

            pizzas.Remove(slice);

            return pizzas;
        }
    }
}
