namespace MyWebAPI.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Topping { get; set; } = string.Empty;

        public string Cheese { get; set; } = string.Empty;

        public string Crust { get; set; } = string.Empty;

        public string Size { get; set; } = string.Empty;

    }
}
