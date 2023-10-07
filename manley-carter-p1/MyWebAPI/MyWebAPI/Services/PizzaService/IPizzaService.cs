namespace MyWebAPI.Services.PizzaService
{
    public interface IPizzaService
    {
        List<Pizza> GetAllPizza();
        Pizza? GetOnePizza(int id);
        List<Pizza> AddPizza(Pizza slice);
        List<Pizza>? UpdatePizza(int id, Pizza request);
        List<Pizza>? DeletePizza(int id);
    }
}
